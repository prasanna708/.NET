using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //To calculate factorial of given number
            int n;
            int i = 1;
            long result = 1;
            Console.Write("Enter your number: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine("Invalid input");
            }
            while (i <= n) {
                 result *= i;
                 i++;
             }
            

            Console.WriteLine("Factorial of given number is: "+result );
            Console.ReadKey();
        }
    }
}
