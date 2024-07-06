using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05JulyTask_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDate myDate1 = new MyDate();
            myDate1.Display();

            MyDate myDate2 = new MyDate(05,07);
            myDate2.Display();

            MyDate myDate3 = new MyDate(05,07,2024);
            myDate3.Display();

            Console.WriteLine("Today's Date and Time: " + DateTime.Now.ToString());

            Console.ReadKey();

        }
    }
}
