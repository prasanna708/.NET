using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10JulyTask_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mobile mobile = new Mobile();
            mobile.DecBrightness();
            mobile.IncBrightness();

            Laptop laptop = new Laptop();
            laptop.DecBrightness();
            laptop.IncBrightness();

            Console.ReadKey();
        }
    }
}
