using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace PETS_SOS.TOOLS
{
    public class clsChs
    {
        public static void onlyLetters(TextCompositionEventArgs e)
        {
            int ascci = Convert.ToInt32(Convert.ToChar(e.Text));
            if (ascci >= 65 && ascci <= 90 || ascci >= 97 && ascci <= 122)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Just can write letters!", "Warning!", MessageBoxButton.OK);
                e.Handled = true;
            }


        }
    }
}
