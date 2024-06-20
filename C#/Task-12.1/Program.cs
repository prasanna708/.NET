using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create an array of 5 city names and display them in Reverse order.

            string[] city = new string[] { "Hyderabad", "Warangal", "Nizambad", "Khammam", "Karimnagar" };
            for (int i = city.Length - 1; i >= 0; i--) { 
                Console.Write(city[i]);
                if (i > 0)
                {
                    Console.Write(",");
                }
            }
            Console.ReadKey();
        }
    }
}
