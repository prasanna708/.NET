using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Accept first letter of selected mobile brand print full name of mobile brand
            char ch;
            Console.Write("Enter first letter of selected brands: ");
            ch = Convert.ToChar(Console.ReadLine());
            switch (ch) { 
                case 'O':
                    Console.WriteLine("OnePlus");
                    break;
                case 'S':
                    Console.WriteLine("Samsung");
                    break;
                case 'I':
                    Console.WriteLine("Iphone");
                    break;
                case 'P':
                    Console.WriteLine("Poco");
                    break;
                case 'R':
                    Console.WriteLine("Redmi");
                    break;
                case 'N':
                    Console.WriteLine("Nothing");
                    break;
                case 'V':
                    Console.WriteLine("Vivo");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;

            }


            Console.WriteLine("-----------------------------------------------------------------------------------------");

            //Accept numbers 1,2,---7 and print respective days mon,tue,---sun
            int num;
            Console.Write("Enter your number: ");
            num = Convert.ToInt32(Console.ReadLine());
            
            switch(num)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("sunday");
                    break;
                default :
                    Console.WriteLine("Please enter numbers b/w 1 to 7");
                    break;

            }

            Console.ReadKey();

        }
    }
}
