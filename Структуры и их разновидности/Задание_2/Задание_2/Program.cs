using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    class Program
    {
        class MyClass
        {
            public string change;


        }

        struct MyStruct
        {
            public string change;

        }

        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "изменено";
        }

        static void StruktTaker(MyStruct myStruct)
        {
            myStruct.change = "изменено";
        }


        static void Main(string[] args)
        {
            MyClass myclass = new MyClass();
            MyStruct mystruct = new MyStruct();

            myclass.change = "не изменено";
            mystruct.change = "не изменено";

            ClassTaker(myclass);
            StruktTaker(mystruct);

            Console.WriteLine(myclass.change);
            Console.WriteLine(mystruct.change);

            Console.ReadKey();
        }
    }
}
