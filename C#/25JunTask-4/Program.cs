using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25JunTask_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            try
            {
                Console.WriteLine("Enter a and b values: ");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());

                c = a / b;
                Console.WriteLine(c);
            }
            catch(DivideByZeroException ex)
            { 
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
