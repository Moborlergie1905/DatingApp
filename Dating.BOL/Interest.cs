using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dating.BOL
{
    public class Interest
    {
        public int ID { get; set; }
        public int ProfileID { get; set; }
        public int Recepient { get; set; }
        public int Acknowledged { get; set; }

        public virtual Profile Profile { get; set; }
    }
}
