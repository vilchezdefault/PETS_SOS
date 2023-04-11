using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using PETS_SOS.BUSINESSLogic;
using PETS_SOS.DATA;
using PETS_SOS.TOOLS;

namespace PETS_SOS.Forms
{
    /// <summary>
    /// Interaction logic for pnlSingUp2.xaml
    /// </summary>
    public partial class pnlSingUp2 : Window
    {
        public pnlSingUp2()
        {
            InitializeComponent();
            txtUserLogg.Text = TOOLS.clsGlobalValue.userLogin;
        }
        /// <summary>
        /// Logic from dto.User to save a new user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string status;
            if (txtUsername.Text.Length > 0 && txtPassword !=null)
            {
                if (ckStatus.IsChecked == true)
                {
                    status = "A";
                }
                else
                {
                    status = "I";
                }

                clsUser user = new clsUser(txtUsername.Text, txtPassword.Text, status,userLog.userLogd,DateTime.Now);

                dtoUser userT = new dtoUser();
                if (userT.saveUser(user) == true)
                {
                    MessageBox.Show("Save complete!");
                }
                else
                {
                    MessageBox.Show("Wrong Data!");

                }
               
                txtUsername.Text = "";
                txtPassword.Text="";
            }
            else
            {
                MessageBox.Show("You need fo fill all spaces");
            }
        }

        private void txtUsername_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            TOOLS.clsChs.onlyLetters(e);
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
