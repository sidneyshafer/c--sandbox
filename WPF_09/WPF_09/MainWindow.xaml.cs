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

namespace WPF_09
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //match list
            List<Match> matches = new List<Match>();
            matches.Add(new Match()
            {
                Team1 = "Bayern Munich",
                Team2 = "Real Madrid",
                Score1 = 3,
                Score2 = 2,
                Completion = 85
            });

            matches.Add(new Match()
            {
                Team1 = "PSG",
                Team2 = "Barca",
                Score1 = 1,
                Score2 = 4,
                Completion = 55
            });

            matches.Add(new Match()
            {
                Team1 = "BVB Dortmund",
                Team2 = "AS Roma",
                Score1 = 5,
                Score2 = 2,
                Completion = 72
            });

            matches.Add(new Match()
            {
                Team1 = "Man United",
                Team2 = "La Galaxy",
                Score1 = 0,
                Score2 = 1,
                Completion = 25
            });

            // assign matches to list box
            lblMatches.ItemsSource = matches;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(lblMatches.SelectedItem != null)
            {
                MessageBox.Show("Selected Match\n"
                    + (lblMatches.SelectedItem as Match).Team1 + " "
                    + (lblMatches.SelectedItem as Match).Score1 + " : "
                    + (lblMatches.SelectedItem as Match).Score2 + " "
                    + (lblMatches.SelectedItem as Match).Team2 + " "
                    );
            }

        }
    }

    // Match class
    public class Match
    {
        public int Score1 { get; set; }
        public int Score2 { get; set; }
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public int Completion { get; set; }
    }
}
