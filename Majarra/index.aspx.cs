using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace Majarra
{
    public partial class index : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
           


                try
                {
                    if (Session["email"]==null || Session["email"].Equals(""))
                    {
                        sign_out_link.Visible = false;
                         profile.Visible = false;
                       login_link.Visible = true;
                         sign_up_link.Visible = true;

                    }
                    else
                    {
                        login_link.Visible = false;
                        sign_up_link.Visible = false;
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
                   login_link.Visible = true;
                    sign_up_link.Visible = true;
                }

           
        }

        protected void Sign_Up_Click(object sender, EventArgs e)
        {
           // Response.Write("<script>alert('testing');</script>");
            
            if (CheckUserExist(email_signup.Text.Trim()))
            {
                Response.Write("<script>alert('email is already registered');</script>");
            }
            else if (!IsValidEmail(email_signup.Text.Trim()))
            {
                Response.Write("<script>alert('email is invalid');</script>");
            }
            else if (!checkPassword(password_signup.Text.Trim()))
            {
                Response.Write("<script>alert('password is too short');</script>");
            }
            else if (user_name_signup.Text.Trim().Length < 7)
            {
                Response.Write("<script>alert('user name is too short');</script>");
            }
            else
            {
                addUser();
            }
            
        }

        protected void login_Click(object sender, EventArgs e)
        {
            //Response.Write("<script>alert('testing');</script>");
            if (!IsValidEmail(email_login.Text.Trim()))
            {
                Response.Write("<script>alert('email is invalid');</script>");
            }
            else if (CheckUserExist(email_login.Text.Trim()))
            {

                try
                {

                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    string pass = FormsAuthentication.HashPasswordForStoringInConfigFile(password_login.Text.Trim(), "SHA1");
                    SqlCommand cmd = new SqlCommand("select * from users_data where email='" + email_login.Text.Trim() + "' AND password='" + pass + "';", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        
                        while (dr.Read())
                        {
                            Session["email"] = dr.GetValue(1).ToString();
                            Session["name"] = dr.GetValue(2).ToString();
                            Session["id"] = dr.GetValue(0).ToString();

                        }
                        
                        Response.Redirect("index.aspx");

                    }
                    else
                    {
                        Response.Write("<script>alert('password is incorrect');</script>");
                    }

                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message.ToString() + "');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('this email does not exist');</script>");
            }
        }

        protected void sign_out_click(object sender, EventArgs e)
        {
            Session["name"] = "";
            Session["email"] = "";
            Session["id"] = "";
            Response.Redirect("index.aspx");
        }

        protected bool CheckUserExist(string email)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * from users_data where email = '" + email + "';", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                if (dt.Rows.Count >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                return false;
            }

        }


        protected void addUser()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO users_data (email,password,name) values(@email,@password,@name)  ", con);
                string pass = FormsAuthentication.HashPasswordForStoringInConfigFile(password_signup.Text.Trim(), "SHA1");
                cmd.Parameters.AddWithValue("@email", email_signup.Text.Trim());
                cmd.Parameters.AddWithValue("@password", pass);
                cmd.Parameters.AddWithValue("@name", user_name_signup.Text.Trim());
                cmd.ExecuteNonQuery();
                con.Close();

                Response.Write("<script>alert('done');</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        protected static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    var domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        protected bool checkPassword(string s)
        {
            if (s.Length < 8) return false;
            return true;
        }

        
    }
}

