using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09JulyTask_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ECE ece = new ECE();
            ece.Subjects();
            ece.Duration();
            CSE cse = new CSE();    
            cse.Subjects();
            cse.Duration();
            IT it = new IT();   
            it.Subjects();
            it.Duration();

            Console.ReadKey();
        }
    }
}
