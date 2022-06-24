using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = true;
            int sum = 0;

            while(check)
            {
                string text = Console.ReadLine();
                if(int.TryParse(text, out int number))
                {
                    sum += number;
                }
                else if(text == "sum")
                {
                    Console.WriteLine(sum);
                }
                else if(text == "exit")
                {
                    check = false;
                }
                else
                {
                    Console.WriteLine("error");
                    continue;
                }
            }

        }
    }
}
