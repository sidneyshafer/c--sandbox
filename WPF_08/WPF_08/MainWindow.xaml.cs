﻿using System;
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

namespace WPF_08
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //Create object of Sum class
        public Sum Sumobj { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Sumobj = new Sum { Num1 = "1", Num2 = "3" };
            this.DataContext = Sumobj;
        }
    }
}
