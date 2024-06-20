using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a,b;
            Console.Write("Enter two numbers: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("choice1:+");
            Console.WriteLine("choice2:-");
            Console.WriteLine("choice3:*");
            Console.WriteLine("choice4:/");

            char C;
            Console.Write("Enter symbol to proceed: ");
            C = Convert.ToChar(Console.ReadLine());

            switch(C)
            {
                case '+':Console.WriteLine("Sum is: " + (a + b));  
                         break;
                case '-':Console.WriteLine("Difference is: " + (a - b));
                         break;
                case '*':Console.WriteLine("Product is: " + (a * b));
                         break;
                case '/':Console.WriteLine("Remainder is: " + (a / b));
                         break;
                default:
                    Console.WriteLine("Invalid symbol");
                    break;
                         

            }


            int i;
            for (i = 0; i <= 20; i++) {
                Console.Write(i);
                if (i < 20)
                {
                    Console.Write(", ");
                }
            }
            
            Console.ReadKey();

        }
    }
}
