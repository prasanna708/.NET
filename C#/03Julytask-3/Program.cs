using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Julytask_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ElectricityBill bill = new ElectricityBill();
            bill.CustomerDetalis(1002,"Prasanna Kumar");
            bill.CalculateBill(200,100,6);
            bill.Display();
            Console.ReadKey();
        }
    }
}
