using Microsoft.Win32;
using PETS_SOS.DATA;
using PETS_SOS.DATABASE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

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
        /// <summary>
        /// Function to save a new customer in database
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool saveUser(clsUser data)
        {
            try
            {
                string query = "INSERT INTO PETSOS.dbo.VT_USERS VALUES('" + data.UserName_prop + "', '" + data.Password_prop + "', '" +
                                        data.Status + "', '" + data.Addby + "', '" + data.AddDate + "', null, null);";
                conn.SQLExecuteCmm(_SQLConnection, query);
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }
        /// <summary>
        /// Funtion to look info about ID selected
        /// </summary>
        /// <param name="txtPassword"></param>
        /// <param name="ckStatus"></param>
        /// <param name="txtaddBy"></param>
        /// <param name="txtdateAdd"></param>
        /// <param name="txtupdateBy"></param>
        /// <param name="txtupdateDate"></param>
        /// <param name="user"></param>
        public void lookInfo(TextBox txtPassword, CheckBox ckStatus, TextBox txtaddBy, TextBox txtdateAdd, TextBox txtupdateBy, TextBox txtupdateDate, clsUser user )
  ///SELECT u.USR_USERNAME, u.USR_PASSWORD, u.USR_STATUS, u.USR_AddBy, u.USR_DateAdd, u.USR_UpdateBy, u.USR_DateUpdate FROM VT_USERS U;
        {
            string query = "SELECT u.USR_USERNAME, u.USR_PASSWORD, u.USR_STATUS, u.USR_AddBy,  u.USR_DateAdd,  u.USR_UpdateBy, FROM PETSOS.dbo.VT_USERS WHERE USU_USUARIO = '" + user.UserName_prop + "';";

            var data = conn.SQLCargaDataTable(_SQLConnection, query, null);
            if (data.Rows.Count >0)
            {
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    txtPassword.Text = data.Rows[i].ItemArray[0].ToString();
                    if (data.Rows[i].ItemArray[1].ToString()=="A")
                    {
                        ckStatus.IsChecked = true;
                    }
                    else
                    {
                        ckStatus.IsChecked = false;
                    }
                    txtaddBy.Text = data.Rows[i].ItemArray[2].ToString();
                    txtdateAdd.Text = data.Rows[i].ItemArray[3].ToString();
                    txtupdateBy.Text = data.Rows[i].ItemArray[4].ToString();
                    txtupdateDate.Text = data.Rows[i].ItemArray[5].ToString();
                }
            }
            else
            {
                MessageBox.Show(" ¡Does not found it! ", "Warning");
            }
        }


    }
}
