using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_8._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Accept first name from user and last name from user 
               and display the concatenation first twoletters from 
               first and last two letters of last name.              */
            string fname, lname;
            Console.Write("Enter first name: ");
            fname = Console.ReadLine();
            Console.Write("Enter last name: ");
            lname = Console.ReadLine();

            Console.WriteLine("name is: "+fname.Substring(0,2)+lname.Substring(5,2));
            Console.ReadKey();
        }
    }
}
