using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Runtime.Serialization;
using System.Data.Entity;
using System.Collections.Generic;
using System.Configuration;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using System.Web.Http.Cors;

namespace paths.Controllers
{
    [EnableCors(origins: "https://localhost:44339/api/courses", headers: "*", methods: "*")]
    public class coursesController : ApiController
    {


        //[Route("api/tools")]
        public IEnumerable<courses_data> Get()
        {
            using (MajarraEntities entities = new MajarraEntities())
            {
                entities.Configuration.LazyLoadingEnabled = false;
                return entities.courses_data.Include(a => a.sub_path_data).ToList();
            }
        }


        public HttpResponseMessage Get(int id)
        {
            using (MajarraEntities entities = new MajarraEntities())
            {
                var entity = entities.courses_data.FirstOrDefault(e => e.id == id);
                if (entity != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, entity);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "enter a valid num");
                }
            }
        }

        //[Route("api/tools")]
        public HttpResponseMessage Post(courses_data em)
        {
            try
            {
                using (MajarraEntities entities = new MajarraEntities())
                {
                    entities.courses_data.Add(em);
                    entities.SaveChanges();

                    var message = Request.CreateResponse(HttpStatusCode.Created, em);
                    message.Headers.Location = new Uri(Request.RequestUri + em.id.ToString());

                    return message;
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        public HttpResponseMessage put(int id, courses_data em)
        {
            try
            {
                using (MajarraEntities entities = new MajarraEntities())
                {
                    var entity = entities.courses_data.FirstOrDefault(a => a.id == id);
                    if (entity == null)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "enter a valid id");
                    }
                    else
                    {
                        entity.name = em.name;
                        entity.level = em.level;
                        entity.type = em.type;
                        entity.sub_path_id = em.sub_path_id;
                        entity.rate = em.rate;
                        entity.icon = em.icon;
                        entity.Course_link = em.Course_link;
                        entity.comments_count = em.comments_count;
                        entity.added_by = em.added_by;

                        entities.SaveChanges();

                        return Request.CreateResponse(HttpStatusCode.OK, entity);
                    }
                }

            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        public HttpResponseMessage Delete(int id)
        {
            try
            {
                using (MajarraEntities entities = new MajarraEntities())
                {
                    var entity = entities.courses_data.FirstOrDefault(a => a.id == id);
                    if (entity == null)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "not found");
                    }
                    else
                    {
                        entities.courses_data.Remove(entity);
                        entities.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }

}

