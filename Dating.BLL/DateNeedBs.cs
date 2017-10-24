using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dating.BOL;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Dating.BLL
{
    public class DateNeedBs
    {
        string conString = ConfigurationManager.ConnectionStrings["datingDB"].ConnectionString;       

        public void Insert(DateRegister date)
        {
            using(SqlConnection con = new SqlConnection(conString))
            {

            }
        }
    }
}
