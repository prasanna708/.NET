using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bigger number among two numbers

            int a,b;
            Console.Write("Enter two numbers: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            int bigNum = (a>b) ? a : b;
            Console.WriteLine("Bigger number is: "+bigNum);


            Console.WriteLine("-------------------------------------------------------------------");

            //bigger number among three numbers
            int num1, num2, num3;
            Console.Write("Enter three numbers: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());

            int bignum = (num1>num2) ? ((num1>num3) ? num1 : num3) :((num2>num3)?num2 : num3);
            Console.WriteLine("Big number among three numbers is: "+bignum);

            Console.ReadKey();
        }
    }
}
