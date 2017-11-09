using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Dating.BOL
{
    public class Profile
    {
        public int ID { get; set; }
        //[Display(Name = "First Name"), Required(ErrorMessage = "First Name is REQUIRED")]
        public string FirstName { get; set; }
        //[Display(Name = "First Name"), Required(ErrorMessage = "Last Name is REQUIRED")]
        public string LastName { get; set; }
        //[Display(Name = "E-mail"), Required(ErrorMessage = "E-mail is REQUIRED")]
        //[DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        //[DataType(DataType.Password)]
        public string Password { get; set; }
        public string Gender { get; set; }
        //[Display(Name = "Date of Birth"), Required(ErrorMessage = "First Name is REQUIRED")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime DOB { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        [Display(Name = "State/Province")]
        public string Province { get; set; }
        [Display(Name = "Relationship Status")]
        public string Marital { get; set; }
        [Display(Name = "Height(ft)")]
        public string Height { get; set; }
        [Display(Name = "Weight(kg)")]
        public string Weight { get; set; }
        [Display(Name = "Body Type")]
        [DisplayFormat(NullDisplayText = "Not Specified")]
        public string BodyType { get; set; }
        [Display(Name = "Have Children?")]
        [DisplayFormat(NullDisplayText = "Not Stated")]
        public string HaveChild { get; set; }
        [Display(Name = "Want Children?")]
        [DisplayFormat(NullDisplayText = "Not Stated")]
        public string WantChild { get; set; }
        [Display(Name = "Education Level")]
        [DisplayFormat(NullDisplayText = "Not Specified")]
        public string Education { get; set; }
        public string Ethnicity { get; set; }
        [DisplayFormat(NullDisplayText = "Not Specified")]
        public string Religion { get; set; }
        [DisplayFormat(NullDisplayText = "Not Specified")]
        public string Occupation { get; set; }
        [Display(Name = "Do you smoke?")]
        [DisplayFormat(NullDisplayText = "Not Specified")]
        public string Smoke { get; set; }
        [DisplayFormat(NullDisplayText = "Not Specified")]
        [Display(Name = "Do you drink?")]
        public string Drink { get; set; }
        [Display(Name = "Looking for?")]
        [DisplayFormat(NullDisplayText = "Not Specified")]
        public string RelationshipType { get; set; }
        [Display(Name = "Mobile number")]
        public string Mobile { get; set; }
        [Display(Name = "Display Name")]
        [DisplayFormat(NullDisplayText = "Not Specified")]
        public string Nickname { get; set; }
        [Display(Name = "Describe yourself briefly")]
        [DisplayFormat(NullDisplayText = "Not Stated")]
        public string Desc { get; set; }
        public string IsActivated { get; set; }
        public int Age { get; set; }

        public virtual ICollection<ProfileImage> ProfileImages { get; set; }
        public virtual ICollection<DateRegister> DateRegisters { get; set; }
        public virtual ICollection<Interest> Interests { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
    }
}
