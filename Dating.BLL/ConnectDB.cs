using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dating.BLL
{
    public class ConnectDB
    {
        public string SetConnection
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["datingDB"].ConnectionString;
            }
           
        }
    }
}
