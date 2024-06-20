using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace task_12._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Accept n numeric elements into an array at runtime and print the sum of array.
            Console.Write("Enter no. of values: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n];
            Console.WriteLine("enter numbers:");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("The given numbers are :");
            for (int i = 0; i < numbers.Length; i++) 
            {
            Console.Write(numbers[i]);
                if (i < numbers.Length - 1) 
                { 
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
            int sum = 0;
            foreach (int i in numbers) { 
                sum += i;
            }
            Console.WriteLine("Sum is:" + sum);

            Console.ReadKey();
        }
    }
}
