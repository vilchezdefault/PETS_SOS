using PETS_SOS.BUSINESSLogic;
using PETS_SOS.DATA;
using PETS_SOS.TOOLS;
using System;
using System.Collections.Generic;
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

namespace PETS_SOS.Forms
{
    /// <summary>
    /// Interaction logic for pnlSingUp.xaml
    /// </summary>
    public partial class pnlSingUp : Window
    {
        public pnlSingUp()
        {
            InitializeComponent();
        }


        private void txtUsername_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            TOOLS.clsChs.onlyLetters(e);
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (txtUser.Text.Length > 0 && txtPassword.Password.ToString().Length > 0)
            {
                clsUser user = new clsUser(txtUser.Text, txtPassword.Password.ToString());

                //data transfer object DTO que comunica con la base de datos
                dtoUser usu = new dtoUser();
                if (usu.RequestLogin(user) == true)
                {
                    clsGlobalValue.userLogin = user.UserName_prop;
                    pnlMain window = new pnlMain();
                    window.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Something its wrong!");
                }
            }
            else
            {
                MessageBox.Show("Fill in the fields USERNAME and PASSWORD");
            }
        }

        private void txtSingUp_Click(object sender, RoutedEventArgs e)
        {
            var ventana = new pnlSingUp2();

            ventana.Show();
        }
    }
}
