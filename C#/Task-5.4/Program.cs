using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Print 1 to 20 even numbers
            int i = 0;
            while (i<=20)
            {
                Console.Write(i);
                i = i + 2;
                if (i <= 20)
                {
                    Console.Write(", ");
                }
            }

            Console.ReadKey();
        }
    }
}
