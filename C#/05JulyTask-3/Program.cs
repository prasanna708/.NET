using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05JulyTask_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.DisplayEmpDetails();

            Employee.DisplayCompName();     //calling static method

            Console.ReadKey();
        }
    }
}
