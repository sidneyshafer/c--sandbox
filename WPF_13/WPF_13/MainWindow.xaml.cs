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

namespace WPF_13
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

        private void rdoYes_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Thanks :)\nI like you too!");
        }

        private void rdoNo_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You didn't click yes? ;(");
        }

        private void rdoMaybe_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You should click yes ;)");
        }
    }
}
