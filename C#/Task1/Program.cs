using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Accept mobile no. from user and print in on the screen.
            long num;
            Console.Write("Enter your Mobile number: ");
            num = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Your Mobile number is: "+num);

            Console.WriteLine("------------------------------------------------------------------------------");

            //2.Accept length and breadth of Rectangle and display area & perimeter.
            int len, bth;
            Console.Write("Enter length of Rectangle: ");
            len = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Breadth of Rectangle: ");
            bth = Convert.ToInt32(Console.ReadLine());
            int area = len * bth;
            int perimeter = 2*(len+bth);
            Console.WriteLine("Area of Rectangle is: "+area);
            Console.WriteLine("Perimeter of Rectangle is: "+perimeter);

            Console.WriteLine("------------------------------------------------------------------------------");

            //3.Accept Radius of Circle and display area & perimeter.
            int r;
            Console.Write("Enter radius of Circle: ");
            r = Convert.ToInt32(Console.ReadLine());
            double area1 = Math.PI * r * r;
            double perimeter1 = 2 * Math.PI * r;
            Console.WriteLine("Area of Circle is: "+area1);
            Console.WriteLine("Perimeter of Circle is: "+perimeter1);

            Console.WriteLine("------------------------------------------------------------------------------");

            //4.Accept roll no.,name of student,marks in 3 subjects and display total & average.
            long RollNo;
            String Name;
            int M1,M2,M3;
            Console.Write("Enter your Roll No: ");
            RollNo = Convert.ToInt64(Console.ReadLine());
            Console.Write("Enter your name: ");
            Name = Console.ReadLine();
            int sub1,sub2,sub3;
            Console.Write("Enter Sub1 Marks: ");
            sub1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Sub2 Marks: ");
            sub2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Sub3 Marks: ");
            sub3 = Convert.ToInt32(Console.ReadLine());
            int total, avg;
            total = sub1 + sub2 + sub3;
            avg = (sub1+sub2+sub3)/3;
            Console.WriteLine("Total marks:"+total);
            Console.WriteLine("Average marks: "+avg);

            Console.ReadLine();

        }
    }
}
