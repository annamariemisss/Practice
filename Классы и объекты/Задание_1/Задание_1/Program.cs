using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    class Program
    {
        class Rectangle
        {
            private double side1_;
            private double side2_;
            public double Area
            {
                get
                {
                    return AreaCalculator();
                }
            }
            public double Perimeter
            {
                get
                {
                    return PerimeterCalculator();
                }
            }

            public Rectangle(double side1, double side2)
            {
                side1_ = side1;
                side2_ = side2;
            }

            private double AreaCalculator()
            {

                return side1_ * side2_;
            }

            private double PerimeterCalculator()
            {
                return (side1_ + side2_) * 2;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину первой стороны прямоугольника: ");
            double s1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите длину второй стороны прямоугольника: ");
            double s2 = Convert.ToDouble(Console.ReadLine());
            Rectangle rect = new Rectangle(s1, s2);
            Console.WriteLine("Площадь -  " + rect.Area + "\tПериметр - " + rect.Perimeter);
            Console.ReadLine();
        }
    }
}