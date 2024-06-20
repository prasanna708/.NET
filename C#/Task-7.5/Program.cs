using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // to print 10 to 1 tables
            int a, b;
            for (a = 10; a > 0; a--)
{
                for (b = 1; b <= 10; b++)
{
                    Console.WriteLine(a + "X"  +b + " =" +a * b);
                }
                Console.WriteLine( "press any key..");
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}
