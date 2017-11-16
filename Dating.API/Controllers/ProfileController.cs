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

                var prof = objBs.GetAll().Where(x => x.ID == id).SingleOrDefault();
                    if(prof != null)
                    {
                    //prof = profile;

                    prof.FirstName = profile.FirstName;
                    prof.LastName = profile.LastName;
                    prof.Gender = profile.Gender;
                    prof.DOB = Convert.ToDateTime(profile.DOB);
                    prof.Email = profile.Email;
                    prof.BodyType = profile.BodyType;
                    prof.Height = profile.Height;
                    prof.Weight = profile.Weight;
                    prof.City = profile.City;
                    prof.Country = profile.Country;
                    prof.Desc = profile.Desc;
                    prof.Drink = profile.Drink;
                    prof.Education = profile.Education;
                    prof.Smoke = profile.Smoke;
                    prof.WantChild = profile.WantChild;
                    prof.HaveChild = profile.HaveChild;
                    prof.Province = profile.Province;
                    prof.Nickname = profile.Nickname;
                    prof.Marital = profile.Marital;
                    prof.Occupation = profile.Occupation;
                    prof.Mobile = profile.Mobile;
                    prof.Password = profile.Password;
                    prof.IsActivated = profile.IsActivated;
                    prof.RelationshipType = profile.RelationshipType;
                    prof.Religion = profile.Religion;
                    prof.Ethnicity = profile.Ethnicity;                    

                    objBs.Update(prof);
                        return Ok(prof);
                    }
                    else
                    {
                        return Content(HttpStatusCode.NotFound, "Not found");
                    }
                    
                
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
                //var gender = objBs.GetAll().Single(p => p.ID == id).Gender;
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
