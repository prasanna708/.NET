using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11JulyTask_3
{
    internal class Program
    {
        //Dynamic Polymorphism
        interface IRBI
        {
            double InterestRates();
        }
        class SBI : IRBI
        {
            public double InterestRates()
            {
                Console.WriteLine("State Bank of India Interest Rate: ");
                return 7.9;
            }
        }
        class HDFC : IRBI
        {
            public double InterestRates()
            {
                Console.WriteLine("HDFC Bank Interest Rate: ");
                return 8.7;
            }
        }
        static void Main(string[] args)
        {
            //IRBI rbi = new HDFC();
            IRBI rbi = new SBI();
            Console.WriteLine(rbi.InterestRates());
            Console.ReadKey();
        }
    }
}
