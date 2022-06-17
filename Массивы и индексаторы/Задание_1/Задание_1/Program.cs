using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание1
{
    class MyMatrix
    {
        private int height;
        private int width;
        private int[,] matrix;

        public MyMatrix(int height_, int width_)
        {
            height = height_;
            width = width_;
        }

        public void fill_matrix_rand()
        {
            Random rand = new Random();
            matrix = new int[height, width];
            for (int i = 0; i < height; i++)
            {
                for (int y = 0; y < width; y++)
                {
                    matrix[i, y] = rand.Next(-20, 21);
                }
            }
           
        }


        public void fill_matrix()
        {
            matrix = new int[height, width];
            Console.WriteLine("Введите первую строку : ");
            for (int i = 0; i < height; i++)
            {
                for (int y = 0; y < width; y++)
                {
                    try
                    {
                        matrix[i, y] = Convert.ToInt32(Console.ReadLine());
                    }

                    catch
                    {
                        bool a = true;
                        while (a)
                        {
                            Console.WriteLine("Попробуйте еще раз: ");
                            try
                            {
                                matrix[i, y] = Convert.ToInt32(Console.ReadLine());
                                a = false;
                            }
                            catch
                            {

                            }
                        }
                    }
                }

                Console.WriteLine("\nВведите следующую строку: ");
            }
            

        }


        public int[,] getmymatrix()
        {
            return matrix;
        }

        public void printmatrix()
        {
            for (int i = 0; i < height; i++)
            {
                for (int y = 0; y < width; y++)
                {
                    Console.Write(matrix[i, y] + "\t");
                }

                Console.Write("\n");
            }
        }

        public void ordermatrix(int m)
        {
            for (int i = 0; i < m; i++)
            {
                for (int y = 0; y < m; y++)
                {
                    Console.Write(matrix[i, y] + "\t");
                }

                Console.Write("\n");
            }
        }


    } 
  
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Введите высоту матрицы: ");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите ширину матрицы: ");
            int w = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");


            MyMatrix my = new MyMatrix(h, w);
            Console.WriteLine("Матрица: \n");
            my.fill_matrix_rand();
            my.printmatrix();
            Console.WriteLine("Введите порядок матрицы: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            my.ordermatrix(y);

            Console.ReadKey();
        }
    }
}

