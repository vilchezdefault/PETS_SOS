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
    /// Interaction logic for pnlMain.xaml
    /// </summary>
    public partial class pnlMain : Window
    {
        public pnlMain()
        {
            InitializeComponent();
        }

        private void btnOwners_Click(object sender, RoutedEventArgs e)
        {
            var ventana = new Owner();

            ventana.Show();
        }

        private void btnReport_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnPets_Click(object sender, RoutedEventArgs e)
        {
            var ventana = new pnlSingUp2();

            ventana.Show();
        }

        private void btnUsers_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
