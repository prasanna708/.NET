using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25JunTask_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FormatException 

            int empId;

            try
            {
                Console.WriteLine("Enter Employee Id: ");
                empId = Convert.ToInt32(Console.ReadLine());

            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
