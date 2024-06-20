using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int r = 5; r >=  0; r--) {
                for (int c = 1; c <= r; c++) { 
                    Console.Write(c);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
