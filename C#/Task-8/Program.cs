using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fname, lname, sname;
            Console.Write("Enter first name: ");
            fname = Console.ReadLine();
            Console.Write("Enter last name: ");
            lname = Console.ReadLine();
            Console.Write("Enter surname: ");
            sname = Console.ReadLine();
            Console.WriteLine("Full name is: "+fname+ " " +lname+ " " +sname);
            Console.ReadKey();
        }
    }
}
