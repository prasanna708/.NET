using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Display major or minor by giving current year and born year
            int curryear, bornyear;
            Console.Write("Enter current year: ");
            curryear = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Born year: ");
            bornyear = Convert.ToInt32(Console.ReadLine());
            int age = curryear - bornyear;

            //using if statement only
            if (age >= 18) {
                Console.WriteLine("He/She is major and eligible to vote.");
            }
            if (age < 18)
            {
                Console.WriteLine("He/She is minor and not eligible to vote.");
            }

            Console.WriteLine("--------------------------------------------------------------------------------------");

            //using if-else statement
            if (age > 18) {
                Console.WriteLine("He/She is major and eligible to vote.");
            }
            else
            {
                Console.WriteLine("He/She is minor and not eligible to vote.");
            }

            Console.ReadLine();
        }
    }
}
