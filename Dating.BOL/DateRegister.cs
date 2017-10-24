using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dating.BOL
{
    public class DateRegister
    {
        public int ID { get; set; }
        public int AgeMin { get; set; }
        public int AgeMax { get; set; }
        public string City { get; set; }
        public string HasChild { get; set; } //Future Reference
        public string WantChild { get; set; } //Future Reference
        public int Height { get; set; }
        public int Weight { get; set; }
        public string BodyType { get; set; } 
        public string Education { get; set; } //Future Reference
        public string Ethnicity { get; set; } //Future Reference
        public string Religion { get; set; }//Future Reference
        public string Smoke { get; set; }
        public string Drink { get; set; }
        public string RelationshipType { get; set; }
        public int ProfileID { get; set; }

        public virtual Profile Profile { get; set; }
    }
}
