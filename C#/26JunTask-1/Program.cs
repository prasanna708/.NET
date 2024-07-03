using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;

namespace _26JunTask_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program to accept roll no , name , marks
            // in 3 subjects and write into file called Student.txt
            try
            {
                FileStream fs = new FileStream(@"D:\files\Student.txt", FileMode.Create,FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
               
                Console.WriteLine("Enter roll no. of Student: ");
                int Rno = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Name of Student: ");
                string name = Console.ReadLine();

                Console.WriteLine("Enter marks of student in 3 subjects: ");
                int M = Convert.ToInt32(Console.ReadLine());
                int P = Convert.ToInt32(Console.ReadLine());
                int C = Convert.ToInt32(Console.ReadLine());

                sw.Write(Rno + "," + name + "," + M + "," + P + "," + C);
               
                sw.Flush();
                sw.Close();
                fs.Close();
                Console.WriteLine("File Created Successfully...........");
                

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
