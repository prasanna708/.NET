using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04JulyTask_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Display();

            Product product2 = new Product(102,"Pastery",90);
            product2.Display();

            Console.ReadKey();
        }
    }
}
