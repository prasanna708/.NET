using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12JulyTask_2
{
    class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            Student s1 = new Student();
            s1.RollNo = 1;
            s1.Name = "John";
            s1.Course = "HTML";

            Student s2 = new Student();
            s2.RollNo = 2;
            s2.Name = "Ram";
            s2.Course = "CSS";

            Student s3 = new Student();
            s3.RollNo = 3;
            s3.Name = "Martin";
            s3.Course = "JavaScript";

            Student s4 = new Student();
            s4.RollNo = 4;
            s4.Name = "Naresh";
            s4.Course = "ReactJS";

            Student s5 = new Student();
            s5.RollNo = 5;
            s5.Name = "Smith";
            s5.Course = "Angular";

            students.Add(s1);
            students.Add(s2);
            students.Add(s3);
            students.Add(s4);
            students.Add(s5);

            Console.WriteLine("Students List: ");
            foreach (Student stu in students)
            {
                Console.WriteLine(stu.RollNo + "\t"+ stu.Name + "\t" + stu.Course);
            }

            Console.ReadKey();
        }
    }
}
