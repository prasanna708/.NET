using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program to swap two variables without using third variable.
            int x, y;
            Console.Write("Enter x value and y value: ");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x and y values before swapping:"+x+", "+y);
    
            x = x + y;
            y = x - y;
            x = x - y;
            Console.WriteLine("x and y values after swapping:"+x+","+y);

            Console.WriteLine("-------------------------------------------------------------------------------");

            //Electricity bill
            double MeterNo, PrevReading, CurrReading;
            String CustName;
            Console.Write("Enter MeterNo:");
            MeterNo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter CustName:");
            CustName = Console.ReadLine();
            Console.Write("Enter  PrevReading and CurrReading:");
            PrevReading = Convert.ToDouble(Console.ReadLine());
            CurrReading = Convert.ToDouble(Console.ReadLine());
            double Units, UnitPrice, Bill;
            Units = CurrReading - PrevReading;
            Console.Write("Enter UnitPrice:");
            UnitPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Total Units used: "+Units);
            Bill = UnitPrice * Units;
            Console.WriteLine("Total Bill Amount is: "+Bill);

            Console.WriteLine("-------------------------------------------------------------------------------");
            
            Console.ReadKey();


        }
    }
}
