using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05JulyTask_3
{
    internal class Employee
    {
        private int _Empid;
        private string _EmpName;
        static string _CompanyName;

        public Employee()     //Default Constructor
        {
            _Empid = 108;
            _EmpName = "Prasanna Kumar";
        }

        static Employee()      //Static Constructor
        {
            _CompanyName = "TCS";
        }

        public void DisplayEmpDetails()
        {
            Console.WriteLine("Employ ID: "+_Empid);
            Console.WriteLine("Employ Name: "+_EmpName);
        }

        public static void DisplayCompName()
        {
            Console.WriteLine("Company Name: "+_CompanyName);
        }

    }
}
