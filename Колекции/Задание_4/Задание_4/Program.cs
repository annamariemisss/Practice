using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Задание_4
{
    class Program
    {
        struct employees
        {
            public string name;
            public string post;

            public employees(string name, string post)
            {
                this.name = name;
                this.post = post;
            }
        }



        static void Main(string[] args)
        {
            List<string> posts_ls = new List<string>();
            posts_ls.Add("CEO");
            posts_ls.Add("Director");
            posts_ls.Add("Clerk");
            posts_ls.Add("Manager");
            posts_ls.Add("Interim");
            posts_ls.Add("Professional");

            List<employees> employees_ls = new List<employees>();
            employees_ls.Add(new employees("Edward T", posts_ls[0]));
            employees_ls.Add(new employees("Jason K", posts_ls[1]));
            employees_ls.Add(new employees("Press F", posts_ls[2]));
            employees_ls.Add(new employees("Milka Y", posts_ls[2]));
            employees_ls.Add(new employees("Lana J", posts_ls[3]));
            employees_ls.Add(new employees("Oklin S", posts_ls[4]));
            employees_ls.Add(new employees("Bilbo B", posts_ls[5]));
            
            bool check = true;
            while(check)
            {
                Console.Clear();
                Console.WriteLine("Choose one of the options:\n1 - add dossier\n2 - output all dossiers\n3 - remove all dossiers\n4 - search by name\n5 - exit\n");
                
                switch(int.Parse(Console.ReadLine()))
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Enter name: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Choose post of employee:\n1 - CEO\n2 - Director\n3 - Clerk\n4 - Manager\n5 - Interim\n6 - Professional");
                        int n = int.Parse(Console.ReadLine()) - 1;
                        employees_ls.Add(new employees(name, posts_ls[n]));
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Clear();
                        foreach (employees a in employees_ls)
                            Console.WriteLine($"{a.name} - {a.post}");
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Clear();
                        employees_ls.Clear();
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Enter the employee's name: ");
                        string name_ = Console.ReadLine().ToLower();
                        Regex regex = new Regex($@"{name_}");

                        foreach(employees a in employees_ls)
                        {
                            if (regex.IsMatch(a.name.ToLower()))
                                Console.WriteLine($"{a.name} - {a.post}");
                        }
                        Console.ReadKey();
                        break;

                    case 5:
                        Console.Clear();
                        check = false;
                        break;
                }

            }

        }
    }
}
