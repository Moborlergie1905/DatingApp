using Dating.BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dating.DAL
{
    public class DateRegisterDb : BaseDbConnect
    {        
        public void Insert(DateRegister match)
        {
            db.tblFindDate.Add(match);
            db.SaveChanges();
        }
        public void Update(DateRegister match)
        {
            db.Entry(match).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
