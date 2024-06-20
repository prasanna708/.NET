using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Print category of person depending upon age

            //using else if statement
            int age = 0;
            Console.Write("Enter age : ");
            age = Convert.ToInt32(Console.ReadLine());
            if (age < 4)
            {
                Console.WriteLine("Infant");
            }
            else if (age < 13)
            {
                Console.WriteLine("Kids");
            }
            else if (age < 20)
            {
                Console.WriteLine("Teenager");
            }
            else if (age < 36)
            {
                Console.WriteLine("Adults");
            }
            else if (age < 60)
            {
                Console.WriteLine("Middle age");
            }
            else {
                Console.WriteLine("Senior citizen");
            }

            Console.ReadKey();

        }
    }
}
