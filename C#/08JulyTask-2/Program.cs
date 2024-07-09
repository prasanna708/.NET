using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08JulyTask_2
{
    internal class Program
    {
        //Hierarchical Inheritance
        static void Main(string[] args)
        {
            //Creating object for 2nd class.
            TataMotors tataMotors = new TataMotors();
            tataMotors.Business();
            tataMotors.HeadOfficeAddress();

            //Creating object for 3rd class.
            TCS tCS = new TCS();
            tCS.Business();
            tCS.HeadOfficeAddress();

            Console.ReadKey();
        }
    }
}
