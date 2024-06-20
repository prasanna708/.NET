using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Name;
            Console.WriteLine("Enter your name:");
            Name = Console.ReadLine();
            Console.WriteLine("Good morning! " + Name);
            Console.ReadLine();
        }
    }
}
