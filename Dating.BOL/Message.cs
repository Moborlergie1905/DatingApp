using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dating.BOL
{
    public class Message
    {
        public int ID { get; set; }
        public int ProfileID { get; set; }
        public int Recipient { get; set; }
        public string MsgContent { get; set; }
        public DateTime TimeSent { get; set; }

        public virtual Profile Profile { get; set; }
    }
}
