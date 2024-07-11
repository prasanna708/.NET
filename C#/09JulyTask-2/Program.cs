using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09JulyTask_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TeamLead tl = new TeamLead(20000);
            tl.Salary();
            tl.BranchLoc();
            Developer dev = new Developer(30000);
            dev.Salary();
            dev.BranchLoc();
            Manager manager = new Manager(40000);
            manager.Salary();
            manager.BranchLoc();

            Console.ReadKey();
        }
    }
}
