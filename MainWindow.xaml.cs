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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tmp +=0;
            view.Content = tmp;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            tmp += 1;
            view.Content = tmp;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            tmp += 2;
            view.Content = tmp;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            tmp += 3;
            view.Content = tmp;
        } 

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            tmp += 5;
            view.Content = tmp;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            tmp += 4;
            view.Content = tmp;
        }
        private void Click6(object sender, RoutedEventArgs e)
        {
            tmp += 6;
            view.Content = tmp;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            tmp += 7;
            view.Content = tmp;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            tmp += 8;
            view.Content = tmp;
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            tmp += 9;
            view.Content = tmp;
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            tmp += ',';
            view.Content = tmp;
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            tmp = String.Empty;
            view.Content = tmp;
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            tmp += '+';
            view.Content = tmp;
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            tmp += '-';
            view.Content = tmp;
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            tmp += '/';
            view.Content = tmp;
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            tmp += 'x';
            view.Content = tmp;
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
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
