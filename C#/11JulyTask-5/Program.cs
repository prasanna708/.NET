using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _11JulyTask_5
{
    internal class Program
    {
        //Properties in C#
        //Using getters and setters
        class MyClass
        {
            private string _Name;
            public string name
            {
                get
                {
                    return _Name;
                }
                set
                {
                    _Name = value;
                }
            }
        }
        static void Main(string[] args)
        {
            MyClass ms = new MyClass();
            ms.name = "Prasanna Kumar";
            Console.WriteLine("My name is: "+ms.name);
            Console.ReadKey();
        }
    }
}
