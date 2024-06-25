using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _25JunTask_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IndexOutOfRangeException 
            int[] numbers = new int[5];
            try
            {
                Console.WriteLine("enter 5 elements: ");
                for (int i = 0; i < numbers.Length; i++)
{
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("The given elements are: ");
                for (int i = 0; i <= numbers.Length; i++)
{
                    Console.Write(numbers[i] + ";");
                }
            }
            catch (IndexOutOfRangeException ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
