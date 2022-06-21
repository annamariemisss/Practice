using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4
{
    class Program
    {
        enum POST
        {
            Junior = 200,
            Middle = 140,
            Senior = 15
        }

        class Accauntant
        { 
            public bool AskForBonus(POST worker, int hours)
            {
                switch(worker)
                {
                    case POST.Junior:
                        if (hours > (int)POST.Junior)
                            return true;
                        break;

                    case POST.Middle:
                        if (hours > (int)POST.Middle)
                            return true;
                        break;

                    case POST.Senior:
                        if (hours > (int)POST.Senior)
                            return true;
                        break;

                    default:
                        Console.WriteLine("error");
                        break;
                }

                return false;
            }
        }

        static void Main(string[] args)
        {
            Accauntant acc = new Accauntant();
            bool check = false;

            Console.WriteLine("Введите должность: \n\nJunior - 200\nMiddle - 140\nSenior - 15\n");
            int s = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество отработанных часов: ");
            int h = int.Parse(Console.ReadLine());

            if (s == 200)
            {
                check = acc.AskForBonus(POST.Junior, h);
            }
            else if (s == 140)
            {
                check = acc.AskForBonus(POST.Middle, h);
            }
            else if(s == 15)
            {
                check = acc.AskForBonus(POST.Senior, h);
            }

            
            if(check == true)
            {
                Console.WriteLine("Сотрудник заслуживает премению!");
            }
            else
            {
                Console.WriteLine("Сотрудник не заслуживает премению!");
            }

            Console.ReadKey();

        }
    }
}
