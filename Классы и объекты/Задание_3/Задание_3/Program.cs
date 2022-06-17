using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    class Program
    {
        class Converter
        {
            private double rub_;
            private double usd_;
            private double eur_;

            public Converter(double usd, double eur, double rub)
            {
                rub_ = rub;
                usd_ = usd;
                eur_ = eur;
            }

            public Converter()
            {

            }

            public double ConvertToGrivna(string valuta)
            {
                valuta = valuta.ToLower().Trim();
                switch (valuta)
                {
                    case "rub":
                        return rub_ * 0.52;
                    case "usd":
                        return usd_ * 29.54;
                    case "eur":
                        return eur_ * 30.83;
                    default:
                        return 0;
                }
            }

            public double ConvertFromGrivna(double grivna, string valuta)
            {
                valuta = valuta.ToLower().Trim();
                switch (valuta)
                {
                    case "rub":
                        return grivna * 1.92;
                    case "usd":
                        return grivna * 0.034;
                    case "eur":
                        return grivna * 0.032;
                    default:
                        return 0;
                }
            }
        }

        static void Main(string[] args)
        {
           
            Console.WriteLine("Если хотите перевести из гривны в одну из валют, введите \"1\"\nЕсли хотите перевести одну из валют в гривны, введите \"2\"");
            string res = Console.ReadLine();
            while (res == "1" || res == "2")
            {
                if (res == "1")
                {
                    Converter conv = new Converter();
                    Console.WriteLine("Введите количество гривен");
                    double gr = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("В какую валюту хотите перевести? (Введите rub, usd или eur)");
                    Console.WriteLine(conv.ConvertFromGrivna(gr, Console.ReadLine()));
                }
                if (res == "2")
                {
                    Console.WriteLine("Введите сумму в рублях");
                    double rub = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите сумму в долларах");
                    double usd = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите сумму в евро");
                    double eur = Convert.ToDouble(Console.ReadLine());

                    Converter conv = new Converter(usd, eur, rub);

                    Console.WriteLine("Какую валюту хотите перевести в гривны? (Введите rub, usd или eur)");
                    Console.WriteLine(conv.ConvertToGrivna(Console.ReadLine()));
                }
                Console.WriteLine("Если хотите перевести из гривны в одну из валют, введите \"1\"\nЕсли хотите перевести одну из валют в гривны, введите \"2\"");
                res = Console.ReadLine();
            }
        }
    }
}