using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10._1
{
    internal class Program
    {
        static void FullName(string fname,string lname)
        {
            Console.WriteLine("Full name is: "+fname+" "+lname);
        }
        static void Main(string[] args)
        {
            //Define a method called FullName () and pass
            //firstName,lastName as parameters and return full name.
            FullName("Prasanna","Kumar");
            Console.ReadKey();
        }
    }
}
