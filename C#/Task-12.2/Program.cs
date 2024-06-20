using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //You need to store the price of the gold per gram
            //for the last one week in an array and displaythe average of it.

            double[] gold = new double[] { 6620, 6630, 6650, 6590, 6615, 6585, 6570 };
            double avg = ( gold[0] + gold[1] + gold[2] + gold[3] + gold[4] + gold[5] + gold[6] ) / 7 ;
            Console.WriteLine( " Average is: "+avg);
             
            Console.WriteLine("--------------------------------------------------------------");

            double average = 0;
            foreach (double i in gold) { 
                average += i ;
            }
            Console.WriteLine("Calculating average using foreach loop is: "+average/7);

            Console.ReadKey();
        }
    }
}
