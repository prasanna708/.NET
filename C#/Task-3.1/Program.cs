using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Accept year from user and print whether it is Leap year or not

            /*Every year that is exactly divisible by four is a leap year,
            except for years that are exactly divisible by 100, but some
            centurial years are leap years if they are exactly divisible by 400.*/
            int year;
            Console.Write("Enter year: ");
            year = Convert.ToInt32(Console.ReadLine());
            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
            {
                Console.WriteLine(+year+ " is Leap year");
            }
            else
            {
                Console.WriteLine(+year+ " is not Leap year");
            }
            Console.ReadLine();

        }
    }
}
