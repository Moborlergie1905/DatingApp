using Dating.BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dating.DAL
{
    public class ProfileDb : BaseDbConnect
    {        
        public IEnumerable<Profile> Get()
        {
            return db.tblProfile.ToList();
        }
        public Profile Get(int id)
        {
            return db.tblProfile.SingleOrDefault(x => x.ID == id);
        }
        public void Insert(Profile profile)
        {
            db.tblProfile.Add(profile);
            db.SaveChanges();
        }
        public void Update(Profile profile)
        {
            db.Entry(profile).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var profile = db.tblProfile.SingleOrDefault(x => x.ID == id);
            db.tblProfile.Remove(profile);
            db.SaveChanges();
        }
    }
}
