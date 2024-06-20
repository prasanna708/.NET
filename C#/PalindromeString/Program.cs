using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Program to print whether a given string is palindrome or not
            string name;
            Console.Write("Enter name: ");
            name = Console.ReadLine();
            string rev = string.Empty;
            for (int i = name.Length - 1; i >= 0; i--) { 
                rev = rev + name[i];

            }
            Console.WriteLine("Reverse string is:"+rev);
            if (rev == name)
            {
                Console.WriteLine(name + " is a Palindrome");
            }
            else { 
                Console.WriteLine(name+" is not a palindrome");
            }
            Console.ReadKey();
        }
    }
}
