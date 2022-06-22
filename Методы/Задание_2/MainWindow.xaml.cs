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

namespace Задание_2
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

        int deliver(int n)
        {
            if (n == 1) return 1;

            return n * deliver(n - 1);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int N = int.Parse(N_tb.Text);

            res.Content = deliver(int.Parse(N_tb.Text));
        }
    }
}
