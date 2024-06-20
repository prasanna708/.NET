using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _19junTask_1
{
    //You are passing an array which contains both even and
    //numbers to a method.But you need to return only even elements.
    internal class Program
    {
        static int[] EvenNums(int[] nums)
        {
            int evenCount = 0;
            foreach (int n in nums)
            {
                if (n % 2 == 0)
                {
                    evenCount++;
                }
            }

            int[] evenNumbers = new int[evenCount];
            int index = 0;
            foreach (int n in nums)
            {
                if (n % 2 == 0)
                {
                    evenNumbers[index] = n;
                    index++;
                }
            }
            return evenNumbers;
    }
        static void Main(string[] args)
        {
            int[] nums = new int[] {1,2,3,4,5,6,7,8,9,10};
          
            int[] evenNums = EvenNums(nums);

            Console.WriteLine("Even numbers:");
            foreach (int num in evenNums)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();
        }
    }
}
