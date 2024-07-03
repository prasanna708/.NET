using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27JunTask_4
{
    internal class Program
    {
        enum Branch
        {
            Hyderabad,Chennai,Banglore
        }
        enum WeekDays
        {
            Monday,Tuesday,Wednesday,Thursday,Friday
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Job location is: " + Branch.Hyderabad);
            Console.WriteLine("Iam living in: " + Branch.Banglore);
            Console.WriteLine(WeekDays.Monday + " is a Working day.");
            Console.WriteLine("On " + WeekDays.Wednesday + ",Iam going to " + Branch.Chennai);
            Console.ReadKey();
        }
    }
}
