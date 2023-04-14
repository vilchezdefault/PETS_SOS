using PETS_SOS.DATABASE;
using PETS_SOS.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;
using PETS_SOS.Forms;

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


        public void searchInfo(TextBox id_owner_prop , TextBox txtFirsName, TextBox second_name_prop, TextBox last_name_prop, TextBox second_last_name, TextBox status, TextBox phone_number_prop,TextBox email_prop,TextBox Status,TextBox Addby, TextBox AddDate,TextBox Updateby,TextBox UpdateDate,clOwner owner)
        {
            string query = "SELECT OWN_SECOND_NAME,OWN_LAST_NAME,OWN_SECOND_LASTNAME,OWN_EMAIL,OWN_STATUS, OWN_ADDBY,OWN_ADDDATE,OWN_UPDATEBY,OWN_UPDATE_DATE FROM VT_OWNERS WHERE OWN_ID_OWNER = '" + owner.id_owner_prop + "';";

            var data = conn.SQLCargaDataTable(_SQLConnection, query, null);
            if (data.Rows.Count >0)
            {
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    //Connection from databse to bring data and show and show on window

                    id_owner_prop.Text = data.Rows[i].ItemArray[1].ToString();
                    txtFirsName.Text = data.Rows[i].ItemArray[2].ToString();
                    second_name_prop.Text = data.Rows[i].ItemArray[3].ToString();
                    last_name_prop.Text = data.Rows[i].ItemArray[4].ToString();
                    phone_number_prop.Text = data.Rows[i].ItemArray[5].ToString();
                    email_prop.Text = data.Rows[i].ItemArray[6].ToString();
                    Status.Text = data.Rows[i].ItemArray[7].ToString();
                    Addby.Text = data.Rows[i].ItemArray[8].ToString();
                    AddDate.Text = data.Rows[i].ItemArray[9].ToString();
                    Updateby.Text = data.Rows[i].ItemArray[10].ToString();
                    UpdateDate.Text = data.Rows[i].ItemArray[11].ToString();
                    
                }
            }
            else
            {
                MessageBox.Show(" ¡It doesn't exist ", "WARNING!");
            }
        }


        /// <summary>
        /// Logic to makes update on the database"query" 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool updateOwner(clOwner data)
        {
            try
            {

                string update = "UPDATE PETSOS.dbo.VT_OWNERS SET OWN_FIRST_NAME = '" + data.firstName_prop +
                                            "', OWN_SECOND_NAME = '" + data.second_name_prop + "', OWN_LAST_NAME = '" + data.last_name_prop +
                                            "', OWN_SECOND_LASTNAME = '" + data.second_lastname_prop + "', OWN_PHONE = '" + data.phone_number_prop +
                                            "', OWN_EMAIL = '" + data.email_prop + "', OWN_STATUS = '" + data.Status + "', " +
                                            "OWN_UPDATEBY = '" + data.Updateby + "', OWN_UPDATE_DATE = '" + data.UpdateDate + "' " +
                                            "WHERE OWN_ID_OWNER = '" + data.id_owner_prop + "'";

                conn.SQLExecuteCmm(_SQLConnection, update);
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
