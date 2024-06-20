using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //While loop
            
            //print 1-10 numbers without last comma
            int i = 1;
            while (i<=10) { 
                Console.Write(i);
                i++;
                if (i<=10) {
                    Console.Write(", ");
                }
            }
            Console.ReadKey();


        }
    }
}
