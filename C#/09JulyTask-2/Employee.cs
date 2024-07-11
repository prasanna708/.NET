using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _09JulyTask_2
{
    abstract class Employee
    {
        public double _Sal;
        public Employee(int _Sal)
        {
            this._Sal = _Sal;
        }
        public abstract void Salary();
        public void BranchLoc()
        {
            Console.WriteLine("Address: Deccan Park Plot No 1, Software Units Layout, Madhapur, Hyderabad, Telangana-500081");
        }
    }

    class TeamLead : Employee
    {
        public TeamLead(int _Sal) : base(_Sal)
        {
            
        }

        public override void Salary()
        {
             
            Console.WriteLine("Salary for TeamLead employees: "+_Sal);
        }
    }

    class Developer : Employee
    {
        public Developer(int _Sal) : base(_Sal)
        {
            
        }

        public override void Salary()
        {
            Console.WriteLine("Salary for Developers : " +_Sal);
        }
    }

    class Manager : Employee
    {
        public Manager(int _Sal) : base(_Sal)
        {
            
        }
        public override void Salary()
        {
            Console.WriteLine("Salary for Manager : " + _Sal);
        }
    }

}
