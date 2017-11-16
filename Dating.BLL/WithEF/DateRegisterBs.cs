using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dating.BOL;
using Dating.DAL;

namespace Dating.BLL.WithEF
{
    public class DateRegisterBs
    {
        DateRegisterDb objDb;
        public DateRegisterBs()
        {
            objDb = new DateRegisterDb();
        }
        public void Insert(DateRegister match)
        {
            objDb.Insert(match);
        }
        public void Update(DateRegister match)
        {
            objDb.Update(match);
        }
        public DateRegister GetById(int profileId)
        {
            return objDb.GetById(profileId);
        }
    }
}
