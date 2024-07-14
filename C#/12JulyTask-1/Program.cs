using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12JulyTask_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Generic Collections List
            List<int> numbers = new List<int>(); 
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);
            Console.Write("numbers List items: ");
            foreach (int i in numbers)
            {
                Console.Write(i);
                if (i < numbers.Count)
                {
                    Console.Write(",");
                }
            }

            Console.WriteLine("\n");

            List<string> countries = new List<string>();
            countries.Add("India");
            countries.Add("Japan");
            countries.Add("China");
            countries.Add("Korea");
            countries.Add("Indonesia");
            countries.Add("USA");
            Console.WriteLine("countries List items: ");
            foreach(string country in countries)
            {
                Console.WriteLine(country);
                
            }
            Console.ReadKey();
        }
    }
}
