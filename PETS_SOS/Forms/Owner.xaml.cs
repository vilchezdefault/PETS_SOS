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
using PETS_SOS.BUSINESSLogic;
using PETS_SOS.DATA;
using PETS_SOS.TOOLS;

namespace PETS_SOS.Forms
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Owner : Window
    {
        public Owner()
        {
            InitializeComponent();
            
            
        }


        private void btnMainWindow_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //private void BtnPets_Click(object sender, RoutedEventArgs e)
        //{
        //    var ventana = new Pet();

        //    ventana.Show();
        //}

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            string status;
            if (txtfirstName.Text.Length > 0 && txtsecondName.Text.Length > 0 && txtLastName.Text.Length > 0 && txtSecondLastName  != null)
            {
                if (ckStatus.IsChecked == true)
                {
                    status = "A";
                }
                else
                {
                    status = "I";
                }

                clOwner own = new clOwner(Convert.ToInt32(txtID.Text),txtfirstName.Text,txtsecondName.Text,txtLastName.Text,txtSecondLastName.Text,txtEmail.Text,txtPhoneNumber.Text, clsGlobalValue.userLogin, DateTime.Now,status);

                dtoOwner owner = new dtoOwner();
                if (owner.saveOwner(own) == true)
                {
                    MessageBox.Show("Save complete!");
                }
                else
                {
                    MessageBox.Show("Wrong Data!");

                }

                //txt.Text = "";
                //txtPassword.Text = "";
            }
            else
            {
                MessageBox.Show("You need fo fill all spaces");
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (txtID.Text.Length > 0 && txtfirstName.Text.Length > 0 && txtsecondName.Text.Length > 0 && txtLastName.Text.Length > 0 && txtSecondLastName != null)
            {
                string status;
                if (ckStatus.IsChecked == true)
                {
                    status = "A";
                }
                else
                {
                    status = "I";
                }

                clOwner own = new clOwner(0,Convert.ToInt32(txtID.Text), txtfirstName.Text, txtsecondName.Text, txtLastName.Text, txtSecondLastName.Text, txtEmail.Text, txtPhoneNumber.Text, clsGlobalValue.userLogin, DateTime.Now,status);

                dtoOwner owner = new dtoOwner();
                if (owner.updateOwner(own) == true)
                {
                    MessageBox.Show("Update complete!");
                }
                else
                {
                    MessageBox.Show("Wrong Data!");

                }

            }
            else
            {
                MessageBox.Show("You need #ID to complete");
            }
        }

        private void txt_firstNname_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            TOOLS.clsChs.onlyLetters(e);
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {

        }


    }
}
