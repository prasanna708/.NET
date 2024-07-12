using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11JulyTask_4
{
    //Using ToString() method
    class Employee
    {
        private int _Id;
        private string _Name;
        private int _Sal;
        public Employee()
        {
            _Id = 0; _Name = string.Empty; _Sal = 0;
        }
        public Employee(int _Id, string _Name, int _Sal)
        {
            this._Id = _Id; this._Name = _Name; this._Sal = _Sal;   
        }
        ~Employee() {    }   
        public override string ToString()
        {
            return "Emplpyee Id: " + _Id +"\n"+ "Employee's Name: " + _Name +"\n"  + "Employee's Salary: " + _Sal; 
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(11,"Prasanna Kumar",20000);
            Console.WriteLine(emp);
            Console.ReadKey();
        }
    }
}
