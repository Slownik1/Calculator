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

namespace Calculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        string tmp = String.Empty;
        List<string> numbers = new List<string>();

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            tmp += b.Content.ToString();
            view.Content = tmp;
        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            tmp = String.Empty;
            view.Content = String.Empty;
        }

        

        private void Results(object sender, RoutedEventArgs e)
        {
            int length = tmp.Length;
            double results;


            string plus = "+";
            string minus = "-";
            string multiply = "x";
            string divide = "/";

            if (tmp.Contains(plus))
            {
                results = double.Parse(tmp.Substring(0, tmp.IndexOf(plus))) + double.Parse(tmp.Substring(tmp.IndexOf(plus)+1, length - tmp.IndexOf(plus) -1)) ;
                tmp = results.ToString();
                view.Content = results;
            }
            if (tmp.Contains(minus))
            {
                results = double.Parse(tmp.Substring(0, tmp.IndexOf(minus))) - double.Parse(tmp.Substring(tmp.IndexOf(minus)+1, length - tmp.IndexOf(minus)-1));
                tmp = results.ToString();
                view.Content = results;
            }
            if (tmp.Contains(multiply))
            {
                results = double.Parse(tmp.Substring(0, tmp.IndexOf(multiply))) * double.Parse(tmp.Substring(tmp.IndexOf(multiply) + 1, length - tmp.IndexOf(multiply) - 1));
                tmp = results.ToString();
                view.Content = results;
            }
            if (tmp.Contains(divide))
            {
                results = double.Parse(tmp.Substring(0, tmp.IndexOf(divide))) / double.Parse(tmp.Substring(tmp.IndexOf(divide) + 1, length - tmp.IndexOf(divide) - 1));
                tmp = results.ToString();
                view.Content = results;
            }


        }
    }
}
