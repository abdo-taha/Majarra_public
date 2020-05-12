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
using paths;
using System.Web.Http.Cors;

namespace paths.Controllers
{
    [EnableCors(origins: "https://localhost:44339/api/paths", headers: "*", methods: "*")]
    public class pathsController : ApiController
    {


        [Route("api/paths")]
        public IEnumerable<path_data> Get()
        {
            using (MajarraEntities entities = new MajarraEntities())
            {
                entities.Configuration.LazyLoadingEnabled = false;
                return entities.path_data.Include(a => a.sub_path_data).ToList();
            }
        }


        public HttpResponseMessage Get(int id)
        {
            using (MajarraEntities entities = new MajarraEntities())
            {
                var entity = entities.path_data.FirstOrDefault(e => e.id == id);
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

        [Route("api/paths")]
        public HttpResponseMessage Post(path_data em)
        {
            try
            {
                using (MajarraEntities entities = new MajarraEntities())
                {
                    entities.path_data.Add(em);
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

        public HttpResponseMessage put(int id, path_data em)
        {
            try
            {
                using (MajarraEntities entities = new MajarraEntities())
                {
                    var entity = entities.path_data.FirstOrDefault(a => a.id == id);
                    if (entity == null)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "enter a valid id");
                    }
                    else
                    {
                        entity.name = em.name;
                        entity.about = em.about;
                        entity.to_learn = em.to_learn;
                        entity.rate = em.rate;
                        entity.details = em.details;
                        entity.Pic = em.Pic;
                            
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
                    var entity = entities.path_data.FirstOrDefault(a => a.id == id);
                    if (entity == null)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "not found");
                    }
                    else
                    {
                        entities.path_data.Remove(entity);
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

