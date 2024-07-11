using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09JulyTask_1
{
    internal class Program
    {
        //overriding and preventing overriding using base keyword.
        class Base
        {
            public void Display()
            {
                Console.WriteLine("Message from base class......");
            }
        }

        class Derived : Base
        {
            public new void Display()
            {
                base.Display();     //calling Display() from Base class
                Console.WriteLine("Message from derived class......");
            }
        }
        static void Main(string[] args)
        {
            Derived derived = new Derived();
            derived.Display();
            Console.ReadKey();
        }
    }
}
