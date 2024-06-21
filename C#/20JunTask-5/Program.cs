using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20JunTask_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program to accept marks of 5 students in 3
            //subjects(m,p,c) and display total and average
            // for each and every student.

            int Students = 5;
            int Subjects = 3;

            double[,] marks = new double[Students, Subjects];

            string[] subjectNames = { "Maths", "Physics", "Chemistry" };

            // Accept marks for each student
            for (int i = 0; i < Students; i++)
            {
                Console.WriteLine("Enter marks for student " +(i+1));
                for (int j = 0; j < Subjects; j++)
                {
                    Console.Write("Enter marks in " + subjectNames[j] + " : ");

                    marks[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }

            // Calculate and display total and average marks for each student
            for (int i = 0; i < Students; i++)
            {
                //Total
                double total = 0;
                for (int j = 0; j < Subjects; j++)
                {
                    total += marks[i, j];
                }
                //Average
                double avg = total / Subjects;

                Console.WriteLine("\n" + "Details of student " + (i + 1));
                Console.WriteLine("Total marks:"+total);
                Console.WriteLine("Average marks:" +avg);
            }

            Console.ReadKey();
        }
    }
}
