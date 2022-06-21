using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание3
{
    class Program
    {

        static class Class
        {
            enum Colors
            {
                Red,
                Green,
                Blue,
                Cyan,
                Yellow
            }
            public static void Print(string stroka, int color)
            {
                switch ((Colors)color)
                {
                    case Colors.Red:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(stroka);
                        Console.ResetColor();
                        break;
                    case Colors.Green:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(stroka);
                        Console.ResetColor();
                        break;
                    case Colors.Blue:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(stroka);
                        Console.ResetColor();
                        break;
                    case Colors.Cyan:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(stroka);
                        Console.ResetColor();
                        break;
                    case Colors.Yellow:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(stroka);
                        Console.ResetColor();
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string str = Console.ReadLine();

            Console.WriteLine("Выберите цвет:\n0 - Red\n1 - Green\n2 - Blue\n3 - Cyan\n4 - Yellow\n\n");
            int n = Convert.ToInt32(Console.ReadLine());

            Class.Print(str, n);

            Console.ReadKey();
        }
    }
    
}
