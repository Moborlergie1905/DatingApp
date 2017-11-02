using Dating.BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dating.DAL
{
    public class BaseDbConnect
    {
        protected DatingDbContext db;
        public BaseDbConnect()
        {
            db = new DatingDbContext();
        }
    }
}
