using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calculating Electricity bill
            int currReading, prevReading,MeterNo;
            String custName;
            Console.Write("Enter MeterNo. : ");
            MeterNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Customer name: ");
            custName = Console.ReadLine();
            Console.Write("Enter Current reading and Previous Reading: ");
            currReading = Convert.ToInt32(Console.ReadLine());
            prevReading = Convert.ToInt32(Console.ReadLine());
           

            int units = currReading - prevReading;
            int price;
            if (units < 50) {
                price = 2;
                int TotPrice = units * price;
                Console.WriteLine("Total price is : "+TotPrice);
            }
            else if (units <100)
            {
                price = 4;
                int TotPrice = units * price;
                Console.WriteLine("Total price is : " +TotPrice);
            }
            else if (units < 200)
            {
                price = 6;
                int TotPrice = units * price;
                Console.WriteLine("Total price is : " + TotPrice);
            }
            else
            {
                price = 8;
                int TotPrice = units * price;
                Console.WriteLine("Total price is : " + TotPrice);
            }

            Console.ReadKey();

        }
    }
}
