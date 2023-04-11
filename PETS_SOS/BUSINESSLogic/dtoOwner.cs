using PETS_SOS.DATABASE;
using PETS_SOS.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PETS_SOS.BUSINESSLogic
{
    public class dtoOwner
    {
        private ConnSQL conn = new ConnSQL();//to create query
        private string _SQLConnection = Conn.GetConnectionStrings();
        /// <summary>
        /// Function to save a new owner in database
        /// </summary>
        /// <param obj="data"></param>
        /// <returns></returns>
        public bool saveOwner(clOwner data)
        {
            try
            {
                string query = "INSERT INTO PETSOS.dbo.VT_OWNERS VALUES('" + data.id_owner_prop + "', '" +
                                                                             data.firstName_prop + "', '" + 
                                                                             data.second_name_prop + "', '" + 
                                                                             data.last_name_prop + "', '" + 
                                                                             data.second_lastname_prop + "', '" + 
                                                                             data.phone_number_prop + "', '" + 
                                                                             data.email_prop + "', '" + 
                                                                             data.Status + "', '" + 
                                                                             data.Addby + "', '" + 
                                                                             data.AddDate + "', null, null);";
                conn.SQLExecuteCmm(_SQLConnection, query);
                return true;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }
        
    }
}
