using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _19junTask_3
{
    internal class Program
    {
        //Write a program to accept n element into array
        //and print sum of odd elements using a Method.
        static int oddSum(int[] nums)
        {
            int sum = 0;
            
            foreach (int i in nums) {
                if (i % 2 != 0)
                { 
                    sum = sum + i;
                }
              
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter count: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[n];
            Console.WriteLine("Enter n numbers:");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            int sum = oddSum(numbers);
            Console.WriteLine("Sum of Odd numbers are:" +sum);
            Console.ReadKey();
        }
    }
}
