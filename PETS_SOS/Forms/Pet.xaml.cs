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
    /// Interaction logic for Pet.xaml
    /// </summary>
    public partial class Pet : Window
    {
        public Pet()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var ventana = new MainWindow();

            ventana.Show();
        }
    }
}
