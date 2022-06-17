using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        public class products
        {
            public string article;
            public string name;
            public double price;

            public products(string article_, string name_, double price_)
            {
                article = article_;
                name = name_;
                price = price_;
            }


        }

        class invoice
        {

            List<products> mylist = new List<products>();

            private int account_ { get; }
            private string customer_ { get; }
            private string provider_ { get; }


            public invoice(int account, string customer, string provider)
            {
                account_ = account;
                customer_ = customer;
                provider_ = provider;


                mylist.Add(new products("T300UyyE", "Mirror", 320.20));
                mylist.Add(new products("Uy697tttSS0", "Tablet", 30034.99));
                mylist.Add(new products("LooLLovera05m", "Walnuts", 159.99));

            }



            public void cost_of_order()
            {
                Console.WriteLine("\n\nВведите артикль товара: ");
                string article_ = Console.ReadLine();
                Console.WriteLine("Введите количество: ");
                int quantity_ = Convert.ToInt32(Console.ReadLine());

                products cost = mylist.FirstOrDefault(c => c.article == article_);
                double cheque = cost.price * quantity_;
                Console.WriteLine("Аккаунт: " + account_ + "\nПокупатель: " + customer_ + "\nПоставщик: " + provider_ + "\nАртикль: " + article_ + "\nОбщая стоимость заказа: " + cheque);
            }

            public void cost_of_order_NDS()
            {
                Console.WriteLine("\n\nВведите артикль товара: ");
                string article_ = Console.ReadLine();
                Console.WriteLine("Введите количество: ");
                int quantity_ = Convert.ToInt32(Console.ReadLine());

                products cost = mylist.FirstOrDefault(c => c.article == article_);
                double cheque = cost.price * quantity_ + cost.price * quantity_ * 0.15;
                Console.WriteLine("Аккаунт: " + account_ + "\nПокупатель: " + customer_ + "\nПоставщик: " + provider_ + "\nАртикль: " + article_ + "\nОбщая стоимость заказа: " + cheque);
            }


        }


        static void Main(string[] args)
        {
            bool check = true;

            Console.WriteLine("Введите номер аккаунта: ");
            int account_ = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ваше имя: ");
            string customer_ = Console.ReadLine();
            Console.WriteLine("Введите поставщика: ");
            string provider_ = Console.ReadLine();


            invoice r = new invoice(account_, customer_, provider_);

            while (check)
            {
                r.cost_of_order();

                Console.WriteLine("Желаете продолжить покупки? (Введите yes если да или любую кнопку, чтобы выйти) ");
                string a = Console.ReadLine();

                if (a != "yes")
                    check = false;

            }



            Console.ReadKey();
        }
    }
}
