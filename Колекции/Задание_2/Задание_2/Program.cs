using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            List<int> ls = new List<int>();
            int sum = 0;
            int N = rand.Next(1, 20);

            for (int i = 0; i < N; i++)
            {
                ls.Add(rand.Next(1, 15000));
            }

            for(int i = 0; i < N; i++)
            {
                Console.Clear();
                sum += ls[i];
                Console.WriteLine($"Клиент номер {i + 1}\nСумма заказа: {ls[i]}\n\nТекущее состояние счёта: {sum}");
                Console.ReadKey();
            }


        }
    }
}
