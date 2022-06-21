using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    class Program
    {
        struct Train
        {
            public int number_of_train;
            public string destination;
            public string datetime;
            
            public Train(int number_of_train_, string destination_, string datetime_)
            {
                number_of_train = number_of_train_;
                destination = destination_;
                datetime = datetime_;
            }

        }

        static void Main(string[] args)
        {
            int number_of_train;
            string destination;
            string datetime;


            Train[] train_array = new Train[5];

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("\n\n Введите поезд!\n");

                Console.WriteLine("Введите номер поезда: ");
                number_of_train = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите пункт назначения: ");
                destination = Console.ReadLine();

                Console.WriteLine("Введите дату и время отправки: ");
                datetime = Console.ReadLine();

                train_array[i] = new Train(number_of_train, destination, datetime);
               

            }


            Console.WriteLine("\n\n Введите номер поезда, чтобы узнать его расписание: ");
            int number_readline = int.Parse(Console.ReadLine());

            foreach (Train a in train_array)
            {
                if (a.number_of_train == number_readline)
                {
                    Console.WriteLine($"\nНомер: {a.number_of_train}\nПункт назначения: {a.destination}\nДата и время отправки: {a.datetime} \n");
                }
            }


            Console.ReadKey();
        }
    }
}
