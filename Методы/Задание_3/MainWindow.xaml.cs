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

namespace Задание_3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void remains_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int first = int.Parse(first_tb.Text);
                int second = int.Parse(second_tb.Text);

                if (rem_r.IsChecked == true)
                    res_tb.Text = Convert.ToString(first % second);
                else if (deg_r.IsChecked == true)
                    res_tb.Text = Convert.ToString(Math.Pow(first, second));
                else if (div_r.IsChecked == true)
                    res_tb.Text = Convert.ToString(first / second);
                else if (konk_r.IsChecked == true)
                    res_tb.Text = Convert.ToString(first + "" + second);
            }

            catch
            {
                MessageBox.Show("error");
            }
            
        }
    }
}
