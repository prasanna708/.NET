using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int r = 0; r <= 5; r++) {
                for (int c = 0; c <= r; c++) {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();    
        }
    }
}
