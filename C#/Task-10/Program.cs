using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    internal class Program
    {
        static void AreaCircle(int r)
        {
            double area = Math.PI * r * r;
            Console.WriteLine("Area of circle is:"+area);
        }
        static double AreaCircle1(int r)
        {
            double area = Math.PI * r * r;
            return area;
        }
        static void Main(string[] args)
        {
            /* Define a method called AreaCircle()and pass radius as
            parameter and return Area of circle (Pi*r*r) */

            AreaCircle(2);
            double A = AreaCircle1(4);
            Console.WriteLine("Area of Circle is:"+A);
            Console.ReadKey();
        }
    }
}
