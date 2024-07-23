using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Numbers;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass(333);
            //Even or Odd Number
            if (myClass.IsEven())
                Console.WriteLine("Even");
            else
                Console.WriteLine("Odd");
            //Palindrome number
            if (myClass.IsPalindrome())
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not Palindrome");
            //Armsrtong Number
            if (myClass.IsArmstrong())
                Console.WriteLine("Armstrong");
            else
                Console.WriteLine("Not Armstrong");

            Console.ReadKey();
        }
    }
}
