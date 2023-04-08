using PETS_SOS.DATA;
using PETS_SOS.DATABASE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PETS_SOS.BUSINESSLogic
{
    public class dtoUser
    {
        private ConnSQL conn = new ConnSQL();//para hacer consultas SQL
        private string _SQLConnection = Conn.GetConnectionStrings();
        /// <summary>
        /// Funtion to request login when app was open
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool RequestLogin(clsUser data)
        {
            try //dbo.VT_USERS
            {
                string query = "SELECT USR_USERNAME FROM PETSOS.dbo.VT_USERS WHERE USR_USERNAME ='"
                    + data.UserName_prop + "' AND USR_PASSWORD = '" + data.Password_prop + "'";

                var exist = conn.SQLCargaDataTable(_SQLConnection, query, null);
                if (exist.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

    }
}
