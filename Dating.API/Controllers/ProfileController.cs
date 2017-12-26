using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dating.BOL;
using Dating.BLL.WithEF;
using System.Threading.Tasks;
using Dating.API.UsefulClasses;

namespace Dating.API.Controllers
{
    public class ProfileController : ApiController
    {
        private ProfileBs objBs;
        private AgeClass age;
        public ProfileController()
        {
            objBs = new ProfileBs();
            age = new AgeClass();
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
                profile.Age = age.getAge(profile.DOB);
                profile.IsActivated = "0";
                objBs.Insert(profile);

                return Ok(profile);
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
                if(profile.ID != id)
                {
                    return Content(HttpStatusCode.NotFound, "Not found");
                }

                objBs.Update(profile);
                return Ok();                
            }
            catch(Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex);
            }            
               
        }

        public IHttpActionResult GetAvailableDate(string gender)
        {
            try
            {                
                var availDates = objBs.GetAll().Where(g => g.Gender != gender).OrderBy(x => Guid.NewGuid()).Take(50);
                return Ok(availDates);
            }
            catch(Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex);
            }
            
        }
    }
}
