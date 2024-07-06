using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05JulyTask_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calling parameteraized constructor
            Employ employ1 = new Employ(18,"Prasanna Kumar",20000);
            employ1.DisplayEmp();

            //Calling Copy Constructor
            Employ employ2 = new Employ(employ1);
            employ2.DisplayEmp();


            Console.ReadKey();
        }
    }
}
