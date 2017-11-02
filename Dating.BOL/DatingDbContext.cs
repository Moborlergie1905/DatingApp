using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dating.BOL
{
    public class DatingDbContext : DbContext
    {
        public DatingDbContext() : base("datingDB")
        { }
        public DbSet<Profile> tblProfile {get; set;}
        public DbSet<DateRegister> tblFindDate { get; set; }
        public DbSet<Interest> tblInterest { get; set; }
        public DbSet<Message> tblChat { get; set; }
        public DbSet<ProfileImage> tblImage { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
