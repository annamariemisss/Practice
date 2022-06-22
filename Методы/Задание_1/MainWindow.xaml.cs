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

namespace Задание_1
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

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Payment_amount_tb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        class MyClient
        {
            public string name;
            public double amount_debt;
            
            public int number_months;

            public MyClient(string name_, double amount_debt_, int number_months_ )
            {
                name = name_;
                amount_debt = amount_debt_;
                number_months = number_months_;
                
            }       
        }

        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MyClient[] clientarray = new MyClient[5];

                clientarray[0] = new MyClient("Edward yt", 400000.00, 21);
                clientarray[1] = new MyClient("Emma d", 30000.00, 3);
                clientarray[2] = new MyClient("Krista l", 1000.00, 1);
                clientarray[3] = new MyClient("Steed m", 150000.00, 18);
                clientarray[4] = new MyClient("Dazai", 0, 32);


                int r = 0;

                for (int i = 0; i < 5; i++)
                {
                    if (Clients_cb.Text == clientarray[0].name)
                    {
                        r = i;
                        break;
                    }
                }

                double monthly_payment = clientarray[r].amount_debt / clientarray[r].number_months;
                double sp = 0;

                if (int.Parse(Payment_amount_tb.Text) - monthly_payment >= 0)
                {
                    sp = int.Parse(Payment_amount_tb.Text) - monthly_payment;
                }

                string win = "";


                if (clientarray[r].amount_debt == 0)
                    win = "Сообщение об отсутствии долга?";
                else
                    win = "";



                res.Content = $"Сумма задолженности - {clientarray[r].amount_debt}\nСумма переплаты - {sp}\n{win}";
            }

            catch
            {
                MessageBox.Show("");
            }
            

        }
    }
}
