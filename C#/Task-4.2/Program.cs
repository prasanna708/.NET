using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Electricity bill 2.0
            int currReading, prevReading,MeterNo;
            String custName;
            Console.Write("Enter MeterNo: ");
            MeterNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Customer name: ");
            custName = Console.ReadLine();

            Console.Write("Enter Current reading and Previous Reading: ");
            currReading = Convert.ToInt32(Console.ReadLine());
            prevReading = Convert.ToInt32(Console.ReadLine());

            int units = currReading - prevReading;
            int price1=2,price2=4,price3=6,price4=8;


            if (units <= 50)
            {
                int TotPrice = units * price1;
                Console.WriteLine("Total price is : " + TotPrice);
            }
            else if (units <= 100)
            {
                int TotPrice = (50*price1) + ((units - 50)*price2); 
                Console.WriteLine("Total price is : " + TotPrice);
            }
            else if (units <= 200)
            {
                int TotPrice = (50 * price1) + (50 * price2) + ((units - 100)*price3);
                Console.WriteLine("Total price is : " + TotPrice);
            }
            else
            {
                int TotPrice = (50 * price1) + (50 * price2) + (100 * price3) + ((units-200)*price4);
                Console.WriteLine("Total price is : " + TotPrice);
            }

            Console.ReadKey();
        }
    }
}
