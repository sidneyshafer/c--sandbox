using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
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

namespace WPFTasks
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //create dependency property
        public static readonly DependencyProperty HtmlProperty = DependencyProperty.RegisterAttached(
            "Html",
            typeof(string),
            typeof(MainWindow),
            new FrameworkPropertyMetadata(OnHtmlChanged));

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
            Task.Run(() =>
            {
                Debug.WriteLine($"Thread Num : {Thread.CurrentThread.ManagedThreadId}");
                //Download something
                HttpClient webClient = new HttpClient();
                //get website results and store it in html variable
                string html = webClient.GetStringAsync("https://google.com").Result;

                //Thread goes back to Main Thread --> owner of MyButton
                MyButton.Dispatcher.Invoke(() =>
                {
                    Debug.WriteLine($"Thread Num : {Thread.CurrentThread.ManagedThreadId}");
                    //Main Thread takes care of all UI elements
                    // MyButton is part of Main Thread (thread 1)
                    MyButton.Content = "Done";
                });
            });
            
        }

        //Same result as MyButton_Click, but is more efficient
        private async void MyButton_Click2(object sender, RoutedEventArgs e)
        {
            string myHtml = "";

            Debug.WriteLine($"Thread Num : {Thread.CurrentThread.ManagedThreadId} before task");
            await Task.Run(async () =>
            {
                Debug.WriteLine($"Thread Num : {Thread.CurrentThread.ManagedThreadId} during task");
                //Download something
                HttpClient webClient = new HttpClient();
                //get website results and store it in html variable
                string html = webClient.GetStringAsync("https://google.com").Result;
                myHtml = html;
            });

            Debug.WriteLine($"Thread Num : {Thread.CurrentThread.ManagedThreadId} after task");
            MyButton.Content = "Done";
            MyWebBrowser.SetValue(HtmlProperty, myHtml);
        }

        static void OnHtmlChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
        {
            WebBrowser webBrowser = dependencyObject as WebBrowser;
            if (webBrowser != null)
            {
                webBrowser.NavigateToString(e.NewValue as string);
            }
        }
    }
}
