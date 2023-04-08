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
            var ventana = new MainWindow();

            ventana.Show();
        }

        private void BtnPets_Click(object sender, RoutedEventArgs e)
        {
            var ventana = new Pet();

            ventana.Show();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void txt_firstNname_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            TOOLS.clsChs.onlyLetters(e);
        }

    }
}
