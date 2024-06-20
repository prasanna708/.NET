using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //To print given number in reverse order
            int n;
            Console.Write("Enter your number: ");
            n = Convert.ToInt32(Console.ReadLine());
            while (n > 0) { 
                int r = n%10;
                Console.Write(r);
                n = n/10;
            }
            Console.ReadKey();
        }
    }
}
