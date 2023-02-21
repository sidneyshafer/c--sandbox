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

namespace WPF_02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Set Grid
            Grid grid = new Grid();
            this.Content = grid;

            //Create a button
            Button btn = new Button();
            btn.FontSize = 26;
            btn.Width = 200;
            btn.Height = 200;
            
            //Create a WrapPanel
            WrapPanel wrapPanel = new WrapPanel();

            //Create TextBlocks
            TextBlock txt1 = new TextBlock();
            txt1.Text = "Multi";
            txt1.Foreground = Brushes.Red;

            TextBlock txt2 = new TextBlock();
            txt2.Text = "Color";
            txt2.Foreground = Brushes.DeepPink;

            TextBlock txt3 = new TextBlock();
            txt3.Text = "Button";
            txt3.Foreground = Brushes.DarkMagenta;

            //Add TextBlocks to WrapPanel
            wrapPanel.Children.Add(txt1);
            wrapPanel.Children.Add(txt2);
            wrapPanel.Children.Add(txt3);

            //Add WrapPanel to Button
            btn.Content = wrapPanel;

            //Add Button to Grid
            grid.Children.Add(btn);
        }
    }
}
