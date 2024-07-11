using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10JulyTask_3
{
    internal class Program
    {
        class Base
        {
            public void Display1()
            {
                Console.WriteLine("Message from Base class.");
            }
        }
        interface IBase
        {
            void Display2();
        }
        class MyClass : Base, IBase
        {
            public void Display2()
            {
                Console.WriteLine("Message from MyClass which inherited IBase interface.");
            }
        }
        static void Main(string[] args)
        {
            MyClass ms = new MyClass(); 
            ms.Display1();
            ms.Display2();

            Console.ReadKey();
        }
    }
}
