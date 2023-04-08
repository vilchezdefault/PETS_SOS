using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PETS_SOS.DATABASE
{
     class Conn
    {
        Conn()
        {

        }

        public static string GetConnectionStrings()
        {
            string outcome = "";
            ConnectionStringSettingsCollection settings =
            ConfigurationManager.ConnectionStrings;

            if (settings != null)
            {
                outcome = settings[0].ConnectionString;
            }
            return outcome;
        }
    }
}
