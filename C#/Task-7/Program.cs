using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Program to print numbers in following order
                1
                22
                333
                4444
                55555
                             */
            for (int r = 1; r <= 5; r++) {

                for (int c = 1; c <= r; c++) {

                    Console.Write(r);
                }
                Console.WriteLine();
            }

            Console.WriteLine("------------------------------------");

            /*Program to print numbers in following order
               55555
               4444
               333
               22
               1 
                            */

            for (int r = 5; r >= 0; r--)
            {

                for (int c = 1; c <= r; c++)
                {

                    Console.Write(r);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
