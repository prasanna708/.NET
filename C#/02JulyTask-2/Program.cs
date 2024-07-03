using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02JulyTask_2
{
    class Student
    {
        private int _rno;
        public string name;
        public void Accept()
        {
            Console.WriteLine("Accepting student details.....");
        }
        internal void Display()
        {
            Console.WriteLine("Displaying student details.......");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.name = "Prasanna Kumar";
            Console.WriteLine(student.name);
            student.Accept();
            student.Display();
        }
    }
}
