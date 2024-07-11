using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09JulyTask_3
{
    abstract class Btech
    {
        public abstract void Subjects();
        public void Duration()
        {
            Console.WriteLine("Duration is 4 years.......");
        }
    }

    class ECE : Btech
    {
        public override void Subjects()
        {
            Console.WriteLine("Branch: ECE");
            Console.WriteLine("subjects : 25");
        }
    }

    class CSE: Btech
    {
        public override void Subjects()
        {
            Console.WriteLine("Branch: CSE");
            Console.WriteLine("subjects : 22");
        }
    }

    class IT : Btech
    {
        public override void Subjects()
        {
            Console.WriteLine("Branch: IT");
            Console.WriteLine("subjects : 20");
        }
    }

}
