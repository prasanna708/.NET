using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _26JunTask_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Write a program to read the Student.txt and
            //display total and average from the marks.

            int Rno, M, P, C, tot;
            string name;
            double avg;
            try
            {
                FileStream fs = new FileStream(@"D:\files\Student.txt",FileMode.Open,FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string data = sr.ReadLine();   
                Console.WriteLine("Reading data from file.....\n ");

                string[] StuRec = data.Split(',');

                //Reading Data
                Rno = Convert.ToInt32(StuRec[0]);
                name = StuRec[1];
                M = Convert.ToInt32(StuRec[2]); 
                P = Convert.ToInt32(StuRec[3]); 
                C = Convert.ToInt32(StuRec[4]);

                tot = M + P + C;    
                avg = tot / 3;

                //Displaying data
                Console.WriteLine("Roll No: " + Rno);
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Marks in maths: " + M);
                Console.WriteLine("Marks in physics: " + P);
                Console.WriteLine("Marks in chemistry: " + C);
                Console.WriteLine("Total Marks: " + tot);
                Console.WriteLine("Average: " + avg);

                sr.Close();
                fs.Close();

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex1) 
            {
                Console.WriteLine(ex1.Message);  
            }

            Console.ReadKey();
        }
    }
}
