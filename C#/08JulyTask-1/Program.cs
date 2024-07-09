using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08JulyTask_1
{
    internal class Program
    {
        //Single Inheritence
        static void Main(string[] args)
        {
            Hostel hostel = new Hostel();
            hostel.SchoolDetails();
            hostel.HostelDetails();
            Console.ReadKey();
        }
    }
}
