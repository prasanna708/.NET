using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11JulyTask_1
{
    internal class Program
    {
        //operator overloading using ++ operator
        class Numbers
        {
            private int a, b;
            public Numbers()
            {
                a = 0; b = 0;
            }
            public Numbers(int a, int b)
            {
                this.a = a; this.b = b;
            }
            ~Numbers() { }
            public static Numbers operator++(Numbers num)
            {
                num.a++;
                num.b++;
                return num;
            }

            public void Display()
            {
                Console.WriteLine("a value: "+a);
                Console.WriteLine("b value: "+b);
            }
        }
        static void Main(string[] args)
        {
            Numbers numbers = new Numbers(9,99);
            //numbers.Display();
            numbers++;
            numbers.Display();
            Console.ReadKey();
        }
    }
}
