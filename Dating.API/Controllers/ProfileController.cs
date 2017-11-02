using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dating.BOL;
using Dating.BLL.WithEF;

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
            if(profile == null)
            {
                return Content(HttpStatusCode.NotFound, "Profile not found for the selected user");
            }
            return Ok(profile);
        }
        public IHttpActionResult Add(Profile profile)
        {
            if (ModelState.IsValid)
            {
                objBs.Insert(profile);
                return Ok();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}
