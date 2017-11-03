using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dating.BOL;
using Dating.BLL.WithEF;
//using Dating.BLL;
using System.Threading.Tasks;

namespace Dating.API.Controllers
{
    public class ProfileController : ApiController
    {
        private ProfileBs objBs;
        public ProfileController()
        {
            objBs = new ProfileBs();
        }
        public IHttpActionResult Get()
        {
            var profiles = objBs.GetAll().ToList();
            if (profiles == null)
            {
                //NotFound();
                return Content(HttpStatusCode.NotFound, "No Profiles");
            }

            return Ok(profiles);
        }
        public IHttpActionResult Get(int id)
        {
            var profile = objBs.GetById(id);
            if (profile != null)
            {
                return Ok(profile);                
            }
            else
            {
                return Content(HttpStatusCode.NotFound, "Profile not found for the selected user");
            }
           
        }

        //[Route("Profile")]
        public IHttpActionResult Post([FromBody] Profile profile)
        {
            try
            {
                profile.IsActivated = "0";
                objBs.Insert(profile);

                //return Created(new Uri(Url.Link("Profile", new { id = profile.ID })), profile);

                //var message = Request.CreateResponse(HttpStatusCode.Created, profile);
                //message.Headers.Location = new Uri(Request.RequestUri + profile.ID.ToString());


                return Ok();
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex);
            }


        }

        public IHttpActionResult Delete(int id)
        {
            objBs.Delete(id);
            return Ok();
        }
        public IHttpActionResult Put(int id, [FromBody] Profile profile)
        {
            try
            {
                using (DatingDbContext db = new DatingDbContext())
                {
                    var prof = db.tblProfile.FirstOrDefault(x => x.ID == id);
                    if(prof != null)
                    {
                        prof.FirstName = profile.FirstName;
                        prof.LastName = profile.LastName;
                        prof.Gender = profile.Gender;
                        prof.DOB = Convert.ToDateTime(profile.DOB);
                        prof.Email = profile.Email;
                        db.SaveChanges();
                        return Ok(profile);
                    }
                    else
                    {
                        return Content(HttpStatusCode.NotFound, "Not found");
                    }
                    
                }
            }
            catch(Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex);
            }
            
            //var prof = objBs.GetAll().SingleOrDefault(x => x.ID == id);
            //if(prof != null)
            //{
            //prof.FirstName = profile.FirstName;
            //prof.LastName = profile.LastName;
            //prof.Gender = profile.Gender;
            //prof.DOB = profile.DOB;
            //prof.Email = profile.Email;
            //objBs.Update(profile);
            //    return Ok();
            //}
            //else
            //{
            //    return Content(HttpStatusCode.NotFound, "No record to update");
            //}          
        }
    }
}
