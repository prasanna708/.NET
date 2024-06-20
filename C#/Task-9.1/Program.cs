using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.Write("Enter a name: ");
            name = Console.ReadLine();
            name = name.ToLower();
            int i,count = 0;
            for (i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
                if (name[i] == 'a' || name[i] == 'e' || name[i] == 'i' || name[i] == 'o' || name[i] == 'u')
                {
                    count++;
                }
            }
            Console.WriteLine("no. of vowels are: " + count);
            Console.ReadKey();
        }
    }
}
