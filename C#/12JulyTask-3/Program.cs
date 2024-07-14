using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12JulyTask_3
{
    //Dictonary Generic collections
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> subjects = new Dictionary<int, string>();
            
            subjects.Add(1, "HTML");
            subjects.Add(2, "CSS");
            subjects.Add(3, "JavaScript");
            subjects.Add(4, "BootStrap");
            subjects.Add(5, "React");

            Console.WriteLine("Subjects in key-value pairs:");
            foreach (var subject in subjects)
            {
                Console.WriteLine(subject);
            }

            Console.ReadKey();
        }
    }
}
