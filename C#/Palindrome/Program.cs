+using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    internal class Program
    {
        private static int sum;

        static void Main(string[] args)
        {
            //To Print whether the given is Palindrome or not
            int num, rem, rev = 0, temp;
            
            Console.Write("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());
            temp = num;
            while (num > 0)
            {
                rem = num % 10;
                num = num / 10;

                rev = rev * 10 + rem;

            }
            Console.WriteLine("The reversed number is: " + rev);
            if (temp == rev)    
            {
                Console.WriteLine("Number is Palindrome ");
            }
            else
            {
                Console.WriteLine("Number is not a palindrome ");
            }
            Console.ReadLine();
        }
    }
}
