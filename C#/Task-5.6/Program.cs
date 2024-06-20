using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 20;
            while(i>=2)
            {
                Console.Write(i);
                i = i - 2 ;
                if(i >= 2)
                {
                    Console.Write(", ");
                }
            }

            Console.ReadKey();
        }
    }
}
