using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program to check whether the given number is prime number or not
            int num, count = 0;
            Console.Write("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i <= num)
{
                if (num % i == 0)
                {
                    count++;
                }
                i++;
            }
            if (count == 2)
            {
                Console.WriteLine(num + " is a Prime number");
            }
            else
            {
                Console.WriteLine(num + " is not a prime number");
            }
            Console.ReadKey();
        }
    }
}
