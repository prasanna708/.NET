using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03JulyTask_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arithmatic arithmatic = new Arithmatic();
            arithmatic.calc(10, 5);
            arithmatic.Add();
            arithmatic.Difference();
            arithmatic.Product();
            arithmatic.Divide();
            Console.ReadKey();
        }
    }
}
