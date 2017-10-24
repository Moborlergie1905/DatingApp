using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dating.BOL
{
    public class ProfileImage
    {
        public int ID { get; set; }
        public string ImagePath { get; set; }
        public int ProfileID { get; set; }

        public virtual Profile Profile { get; set; }
    }
}
