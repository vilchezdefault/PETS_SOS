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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Owner : Window
    {
        public Owner()
        {
            InitializeComponent();
        }

        private void BtnSave(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show(" Número Identificación: " + txtPhoneNumber + "\n" +
                                " Primer Nombre: " + txtFirstName + "\n" +
                                " Segundo Nombre: " + txtsecondName.Text + "\n" +
                                " Primer Apellido: " + txtLastName.Text + "\n" +
                                " Segundo Apellido: " + txtSecondLastName.Text + "\n" +
                                " Correo Electrónico: " + txtEmail.Text + "\n" +
                                " Teléfono Celular: " + txtPhoneNumber.Text + "\n");
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                MessageBox.Show(error);
            }
        }

        private void btnMainWindow_Click(object sender, RoutedEventArgs e)
        {
            var ventana = new MainWindow();

            ventana.Show();
        }

        private void BtnPets_Click(object sender, RoutedEventArgs e)
        {
            var ventana = new Pet();

            ventana.Show();
        }
    }
}
