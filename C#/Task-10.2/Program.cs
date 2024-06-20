using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10._2
{
    internal class Program
    {
        static bool IsPrime(int n) {
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        static void Main(string[] args)
        {
          /*  Define a method called IsPrime() and pass a number and 
             return true if it is Prime otherwise return false.      */
            bool P = IsPrime(15);
            Console.WriteLine(P);
            Console.ReadKey();
        }
    }
}
