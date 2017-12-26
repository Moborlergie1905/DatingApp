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
    public class LookingForController : ApiController
    {
        private DateRegisterBs objBs;
        public LookingForController()
        {
            objBs = new DateRegisterBs();
        }

        public IHttpActionResult Post([FromBody] DateRegister lookingFor)
        {
            objBs.Insert(lookingFor);
            return Ok(lookingFor);
        }
        public IHttpActionResult Put(int id, [FromBody] DateRegister lookingFor)
        {
            try
            {

                if(lookingFor.ID != id)
                {
                    return Content(HttpStatusCode.NotFound, "Not found");
                }

                objBs.Update(lookingFor);

                return Ok();

                //var looking = objBs.GetById(id);
                //if (looking != null)
                //{
                //    looking.AgeMin = lookingFor.AgeMin;
                //    looking.AgeMax = lookingFor.AgeMax;
                //    looking.BodyType = lookingFor.BodyType;
                //    looking.City = lookingFor.City;
                //    looking.Drink = lookingFor.Drink;
                //    looking.Education = lookingFor.Education;
                //    looking.Height = lookingFor.Height;
                //    looking.Weight = lookingFor.Weight;
                //    looking.HasChild = lookingFor.HasChild;
                //    looking.WantChild = lookingFor.WantChild;
                //    looking.RelationshipType = lookingFor.RelationshipType;
                //    looking.Smoke = lookingFor.Smoke;
                //    looking.Ethnicity = lookingFor.Ethnicity;
                //    looking.Religion = lookingFor.Religion;
                //    objBs.Update(looking);

                //    return Ok();
                //}
                //else
                //{
                //    return Content(HttpStatusCode.NotFound, "Not found");
                //}
            }
            catch(Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex);
            }
           
        }
    }
}
