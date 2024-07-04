using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03JulyTask_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployPaySlip emp = new EmployPaySlip();
            emp.AcceptEmployDetails(18, "Prasanna Kumar", 20000);
            emp.CalculateSalary();
            emp.PrintPayslip();
            Console.ReadKey();
        }
    }
}
