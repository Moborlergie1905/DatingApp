using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dating.BOL;
using Dating.DAL;

namespace Dating.BLL.WithEF
{
    public class ProfileBs
    {
        ProfileDb objDb;
        public ProfileBs()
        {
            objDb = new ProfileDb();
        }

        public IEnumerable<Profile> GetAll()
        {
            return objDb.Get();
        }
        public Profile GetById(int id)
        {
            return objDb.Get(id);
        }
        public void Insert(Profile profile)
        {
            objDb.Insert(profile);
        }
        public void Update(Profile profile)
        {
            objDb.Update(profile);
        }
        public void Delete(int id)
        {
            objDb.Delete(id);
        }
    }
}
