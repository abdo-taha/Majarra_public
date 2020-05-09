using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Majarra
{
    
    public partial class course : System.Web.UI.Page
    {
        string path_id, path_name;
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        Dictionary<string, string> courses_levels = new Dictionary<string, string>()
        {
            {"0","beginner" },
            {"1","intermediate" },
            {"2","advanced" }
        };
        Dictionary<string, string> courses_types = new Dictionary<string, string>()
        {
            {"0","text" },
            {"1","audio" },
            {"2","video" }
        };

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["email"] == null || Session["email"].Equals(""))
                {
                    Response.Redirect("index.aspx");


                }
                else
                {
                    
                    sign_out_link.Visible = true;
                    profile.Visible = true;
                    profile_name.InnerText = Session["name"].ToString();
                }
            }
            catch (Exception ex)
            {
                Session["email"] = "";
                sign_out_link.Visible = false;
                profile.Visible = false;


            }
            try
            {
                path_id = Request.QueryString["id"].ToString();
                if (!IsPostBack)
                {
                    load_path();
                    load_sub_path();
                    load_comments();
                    
                }
            }
            catch (Exception ex)
            {
                Response.Redirect("index.aspx");
            }
            
            

        }

        void load_path()
        {
            try
            {


                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }


                SqlCommand cmd = new SqlCommand("SELECT id,name,about,to_learn,rate,details,Pic from path_data where id = '" + path_id + "';", con);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        path_name = dr[1].ToString();
                        page_course_name.InnerHtml = path_name;
                        page_course_about.InnerHtml = dr[2].ToString();
                        page_course_rate.InnerText = dr[4].ToString() + " وجدوه مفيدًا ";
                        page_course_details.InnerHtml = dr[5].ToString();
                        page_course_img.Style["background-image"] = "url(" +dr[6].ToString() +")";
                        foreach(string str in to_learn_de(dr[3].ToString()))
                        {
                            page_course_to_learn.InnerHtml += str;
                        }

                       
                    }
                }

                dr.Close();
                con.Close();
                // posts.Controls.Add(new Literal { Text = addposts.ToString() });
            }
            catch(Exception ex)
            {

            }
        }
        

        void load_sub_path()
        {
            try
            {


                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }


                SqlCommand cmd = new SqlCommand("SELECT id,name,about from sub_path_data where path_id = '" + path_id + "';", con);
                SqlDataReader dr = cmd.ExecuteReader();
                StringBuilder str = new StringBuilder();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        str.Append(sub_path_post(dr[0].ToString(), dr[1].ToString(), dr[2].ToString() ));
                        //Response.Write("<script>alert('" +  + "');</script>");
                    }
                }

                dr.Close();
                con.Close();
                 page_sub_courses.Controls.Add(new Literal { Text = str.ToString() });
                
              // accordionExample.InnerHtml = str.ToString();


            }
            catch (Exception ex)
            {
                
            }


        }
        List<string> to_learn_de(string str)
        {
            string[] tmp = str.Split('$');
            List<string> ret = new List<string>();
            foreach(string sub in tmp)
            {
                 ret.Add("<li>" + sub + "</li>");
            }
            return ret;

        }

        string sub_path_post(string id , string sub_path_name , string sub_path_about )
        {
            StringBuilder str = new StringBuilder();
           
            str.Append("  				<div class=\"card\">\n");
            str.Append(string.Format("   					 <div class=\"card-header\" id=\"heading{0}\">\n", id.ToString()));
            str.Append("      					<h2 class=\"mb-0\">");
            str.Append(string.Format("        					<button class=\"btn btn-link\" type=\"button\" data-toggle=\"collapse\" data-target=\"#collapse{0}\" aria-expanded=\"true\" aria-controls=\"collapse{0}\"> {1} </button>\n ", id.ToString(), sub_path_name));
            str.Append("      					</h2>\n    				 </div>\n ");
            str.Append(string.Format("    				 <div id = \"collapse{0}\" class=\"collapse show\" aria-labelledby=\"heading{0}\" data-parent=\"#accordionExample\">\n", id.ToString()));
            str.Append("     		 			<div class=\"card-body card-color\">\n");
            str.Append(string.Format("     		 				<p>{0}</p>\n", sub_path_about));
            str.Append(string.Format("			 				<div class = \"courses-list\" >\n", id.ToString()));
            str.Append(load_courses(id));
            str.Append("							 </div>\n						  </div>\n    				</div>\n 			    </div>\n");

            return str.ToString();
        }

        string load_courses( string sub_path_id)
        {
            StringBuilder str = new StringBuilder();
            try
            {


                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }


                SqlCommand cmd = new SqlCommand("SELECT id,name,level,type,sub_path_id,rate from courses_data where sub_path_id = '" + sub_path_id + "';", con);
                SqlDataReader dr = cmd.ExecuteReader();
                

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        course_info c_info = new course_info();
                        c_info.course_name = dr[1].ToString();
                        c_info.course_type = courses_types[dr[3].ToString()];
                        c_info.course_rate = dr[5].ToString();
                        c_info.course_level = courses_levels[dr[2].ToString()];
                        
                        str.Append(courses_to_html(c_info));

                    }
                }

                dr.Close();
                con.Close();
                
            }
            catch (Exception ex)
            {

            }


            return str.ToString();
        }

        string courses_to_html(course_info c_inf )
        {
            
            StringBuilder str = new StringBuilder();
            str.Append("     		 				<div class=\"card w-150\">\n");
            str.Append("			 					 <div class=\"card-body row\">\n");
            str.Append("									<div class=\"col-md-1\">\n");
            str.Append("			 					 		<div class = \"rank\" >\n");
            str.Append("			 					 			<span class=\"material-icons\">keyboard_arrow_up</span>\n");
            str.Append( string.Format("			 					 			<p>{0}</p>\n", c_inf.course_rate));
            str.Append("			 					 		</div> \n			 					 	</div>\n");
            str.Append("			 					 	<div class=\"col-md-9\">\n");
            str.Append(string.Format("			  					 		 <h5 class=\"card-title\">{0}</h5>\n", c_inf.course_name));
            str.Append("			  					 		 <br/>\n");
            str.Append("			   							 <div class=\"add-by\">\n");
            str.Append("			   							 	<p class = \"added\"> أضيف بواسطة</p>\n");
            str.Append("			   						 		<div class=\"profile-Pic\"></div>\n");
            str.Append(string.Format("			   						 		<a href = \"{1}\"> {0}</a>\n", c_inf. added_by, c_inf.profile_link));
            str.Append("			   							 </div>\n");
            str.Append(string.Format("		   						 	 <a class = \"comments\" href=\"{0}\"> {1} تعليقات</a>\n", c_inf.comments_link, c_inf.comments_count )  );
            str.Append("		   					 		 <div class=\"hash-list\">\n");
            str.Append(string.Format("		   					 	 		<h5><span class=\"badge badge-secondary\">{0}</span></h5>\n", c_inf.course_level));
            str.Append("		   					 	 		<h5><span class=\"badge badge-secondary\">جديد</span></h5>\n");
            str.Append( string.Format("		   					 	 		<h5><span class=\"badge badge-secondary\">{0}</span></h5>\n", c_inf.course_type) );
            str.Append("		   					 		 </div>\n		   					 	 </div> \n");
            str.Append("		   					 	 <div class=\"col-md-2\">\n");
            str.Append("		 					 		<div class =\"save-it\">\n");
            str.Append("		   					 	 		<span class=\"material-icons\" style=\"display: inline-block; \">collections_bookmark</span>\n");
            str.Append("		   					 	 		<p style = \"display: inline-block; vertical-align: middle; \" > حفظ </ p >\n");
            str.Append("		   					 	 	</div>\n		   					 	 </div>\n 		   					 	</div>\n 		 					 </div>\n");
            return str.ToString();

        }

        void load_comments()
        {
            StringBuilder str = new StringBuilder();
            try
            {


                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }


                SqlCommand cmd = new SqlCommand("SELECT id,path_id,added_by,text,date from comments_data where path_id = '"+path_id +"';", con);
                SqlDataReader dr = cmd.ExecuteReader();


                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        str.Append(comment_to_html(user_from_id(dr[2].ToString()),dr[4].ToString(),dr[3].ToString()));

                    }
                }

                dr.Close();
                con.Close();
                comments_list.InnerHtml = str.ToString();

            }
            catch (Exception ex)
            {

            }
            

        }


        string comment_to_html(string user_name , string time , string text)
        {
            StringBuilder str = new StringBuilder();
            str.Append("                    <div class=\"user-comment\">");
            str.Append("					  <div class=\"profile-Pic\"></div>");
            str.Append("					  <div style = \"display: inline-block; \" >");
            str.Append(string.Format("                              <p id=\"user-name\">{0}</p>", user_name));
            str.Append(string.Format("					            <p id = \"time-label\">{0}</p>", time));
            str.Append(" 					  </div>");
            str.Append(string.Format("					  <p>{0}</p>", text));
            str.Append("					  <div class = \"ctrl-panel\" >");
            str.Append("                           <div class=\"badge\">0</div>");
            str.Append("					  	<button class=\"btn\" class=\"love\"><span style = \"vertical-align: middle; \" class=\"material-icons\">favorite_border</span> أعجبني</button>");
            str.Append("					  	<button class=\"btn\" class=\"reply\"><span style = \"vertical-align: middle; \" class=\"material-icons\">reply</span> إضافة رد</button>");
            str.Append("                      </div>");
            str.Append("					</div>");
            return str.ToString();
        }
        

        protected void sign_out_click(object sender, EventArgs e)
        {
            Session["name"] = "";
            Session["email"] = "";
            Session["id"] = "";
            Response.Redirect("index.aspx");
        }

        protected  void add_comment(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO comments_data (path_id,added_by,text) values(@id,@by,@txt); ", con);
                cmd.Parameters.AddWithValue("@id", path_id);
                cmd.Parameters.AddWithValue("@by", Session["id"].ToString());
                cmd.Parameters.AddWithValue("@txt", new_comment.Value.ToString());
                cmd.ExecuteNonQuery();
                con.Close();
                new_comment.Value = "";
                load_comments();

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        class course_info
        {
           public string course_name="no_name", course_rate="0", added_by="no one", profile_link="#",
                comments_link="#", comments_count="0", course_level="beginner", course_type="video";
        }


        string user_from_id(string id)
        {
            string str = "";
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }


                SqlCommand cmd = new SqlCommand("SELECT name from users_data where user_id = '" + id + "';", con);
                SqlDataReader dr = cmd.ExecuteReader();
                
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        str = dr[0].ToString();
                        break;
                    }
                }

                dr.Close();
                con.Close();
               
            }
            catch(Exception ex)
            {

            }
            return str;


        }


    }


}