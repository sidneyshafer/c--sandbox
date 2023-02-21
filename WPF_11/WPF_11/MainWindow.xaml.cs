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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cbAllCheckedChange(object sender, RoutedEventArgs e)
        {
            bool newVal = (cbAllToppings.IsChecked == true);
            cbHam.IsChecked = newVal;
            cbBlackOlives.IsChecked = newVal;
            cbExtraCheese.IsChecked = newVal;
        }

        private void cbSingleCheckedChange(object sender, RoutedEventArgs e)
        {
            cbAllToppings.IsChecked = null;
            if((cbHam.IsChecked == true) && (cbBlackOlives.IsChecked == true) && (cbExtraCheese.IsChecked == true))
            {
                cbAllToppings.IsChecked = true;
            }
            if((cbHam.IsChecked == false) && (cbBlackOlives.IsChecked == false) && (cbExtraCheese.IsChecked == false))
            {
                cbAllToppings.IsChecked = false;
            }
        }
    }
}
