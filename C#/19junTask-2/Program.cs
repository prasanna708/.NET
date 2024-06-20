using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19junTask_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Accept n elements to an array and print the
            //elements in Sorted order(ascending order).

            Console.Write("Enter count: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n];
            Console.Write("Enter numbers: ");
            for (int i = 0; i < numbers.Length; i++) 
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("-----------------------------------------");
            Array.Sort(numbers);

            Console.WriteLine("The sorted numbers are: ");
            foreach (int i in numbers) { 
                Console.WriteLine(i);
            }
            Console.WriteLine("----------------------------------------");

            //print the Maximum element in array.
            int maxNum = numbers[0];
            for (int i = 1; i < numbers.Length; i++) {
                if (numbers[i] > maxNum) { 
                    maxNum = numbers[i];
                }
            }
            Console.WriteLine("Max. number is: " +maxNum);
            Console.ReadLine();

        }
    }
}
