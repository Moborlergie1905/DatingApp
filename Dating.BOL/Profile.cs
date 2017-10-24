using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dating.BOL
{
    public class Profile
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Marital { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string BodyType { get; set; }
        public string HaveChild { get; set; }
        public string WantChild { get; set; }
        public string Education { get; set; }
        public string Ethnicity { get; set; }
        public string Religion { get; set; }
        public string Occupation { get; set; }
        public string Smoke { get; set; }
        public string Drink { get; set; }
        public string RelationshipType { get; set; }
        public string Mobile { get; set; }
        public string Nickname { get; set; }
        public string Desc { get; set; }
        public string IsActivated { get; set; }
        public int Age { get; set; }

        public virtual ICollection<ProfileImage> ProfileImages { get; set; }
        public virtual ICollection<DateRegister> DateRegisters { get; set; }
        public virtual ICollection<Interest> Interests { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
    }
}
