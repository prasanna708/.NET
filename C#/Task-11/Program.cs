using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11
{
    internal class Program
    {     
     
        static void Main(string[] args)
        {
            //To print reverse string using built-in methods of C#
            Console.Write("Enter a name: ");
            string name = Console.ReadLine();
            char[] Name = name.ToCharArray();
            Array.Reverse(Name);
            string n = new string(Name);
            Console.WriteLine("Reverse String is: " +n);
            Console.ReadKey();
        }
    }
}
