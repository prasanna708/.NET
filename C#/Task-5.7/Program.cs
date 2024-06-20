using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //print n to 1  numbers
            int n;
            Console.Write("Enter n: ");
            n = Convert.ToInt32(Console.ReadLine());

            while (n >= 0) {
                Console.Write(n);
                n--;

            }



            Console.ReadKey();
        }
    }
}
