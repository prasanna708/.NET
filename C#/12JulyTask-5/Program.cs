using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12JulyTask_5
{
    //Queue Generic Collections
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> colors = new Queue<string>();

            colors.Enqueue("Red");
            colors.Enqueue("Blue");
            colors.Enqueue("Green");
            colors.Enqueue("White");
            colors.Enqueue("Black");
            colors.Enqueue("Gold");

            Console.WriteLine("Colors: ");
            foreach (var color in colors)
                Console.WriteLine(color);

            colors.Dequeue();
            colors.Dequeue();
            Console.WriteLine("Colors after Dequeue: ");
            foreach (var color in colors)
                Console.WriteLine(color);

            Console.ReadKey();
        }
    }
}
