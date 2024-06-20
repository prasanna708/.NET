using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // To print 1 to n tables up to m terms.
            int a, b, n, m;
            Console.Write("Enter how many tables you want: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter upto how many terms you want: ");
            m = Convert.ToInt32(Console.ReadLine());
            for (a = 1; a <= n; a++) {

                for (b = 1; b <= m; b++) { 
                    Console.WriteLine(a+ "X" +b+ "=" +(a*b));
                }
                Console.WriteLine("Press any key........");
                Console.ReadKey();
            }
            Console.ReadLine();
        }
    }
}
