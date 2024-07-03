using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27JunTask_3
{
    internal class Program
    {
        struct Student 
        { 
            public string Name;
            public int Rno;
            public double avg;
        }
        static void Main(string[] args)
        {
            //Creating structure variable
            Student s;
            s.Name = "Prasanna Kumar";
            s.Rno = 18;
            s.avg = 77.7146;
            Console.WriteLine(s.Name + "," + s.Rno + "," + s.avg);
            Console.ReadKey();
        }
    }
}
