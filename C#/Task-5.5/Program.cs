using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 3;
            while(i <= 20)
            {
                Console.Write(i);   
                i = i + 2;
                if(i <= 20)
                {
                    Console.Write(", ");
                }
            }

            Console.ReadKey();
        }
    }
}
