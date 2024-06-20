using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arithmatic Operators
            int a = 10;
            int b = 20;
            Console.WriteLine("Sum is: "+(a+b));
            Console.WriteLine("Difference is: "+(b-a));
            Console.WriteLine("Product is: "+(a*b));
            Console.WriteLine("Quotient is: "+(a/b));
            Console.WriteLine("Remainder is: "+(a%b));

            Console.WriteLine("----------------------------------------------------------------------");

            //Pre increment
            int c = 10;
            int d = ++c;
            Console.WriteLine(c);
            Console.WriteLine(d);
            
            Console.WriteLine("----------------------------------------------------------------------");

            //Post increment
            int e = 10;
            int f = e++;
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.ReadKey();

        }
    }
}
