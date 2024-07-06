using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _05JulyTask_2
{
    internal class Employ
    {
        private int _Empid;
        private string _EmpName;
        private double _Sal;

        //Default Constructor
        public Employ() 
        {
            _Empid = 0;
            _EmpName = null;
            _Sal = 0;
        }

        //Parameteraized Constructor
        public Employ(int _Empid, string _EmpName, double _Sal)
        {
            this._Empid = _Empid;
            this._EmpName = _EmpName;   
            this._Sal = _Sal;
        }

        //Copy Constructor
        public Employ(Employ emp)
        {
            this._Empid = emp._Empid;
            this._EmpName = emp._EmpName;
            this._Sal = emp._Sal;
        }

        public void DisplayEmp()
        {
            Console.WriteLine("\n"+"Employ ID: "+_Empid);
            Console.WriteLine("Employ Name: "+_EmpName);
            Console.WriteLine("Salary: "+_Sal);
        }

    }
}
