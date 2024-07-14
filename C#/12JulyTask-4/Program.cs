using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12JulyTask_4
{
    //Stack Generic collections
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<char> alpha = new Stack<char>();
            alpha.Push('A');
            alpha.Push('B');
            alpha.Push('C');
            alpha.Push('D');
            alpha.Push('E');

            Console.WriteLine("Alphabets in Stack: ");
            foreach (char c in alpha)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine("Top element is: "+alpha.Peek());

            alpha.Pop();
            alpha.Pop();
            Console.WriteLine("Alphabets in Stack after pop: ");
            foreach (char c in alpha)
            {
                Console.WriteLine(c);
            }

            Console.ReadKey();
        }
    }
}
