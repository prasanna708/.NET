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

            try
            {
                FileStream fs = new FileStream(@"D:\files\Student.txt",FileMode.Open,FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                //Reading into File
                String RNo = sr.ReadLine();
                String name = sr.ReadLine();    
                string M = sr.ReadLine();
                string P = sr.ReadLine();
                string C = sr.ReadLine();
                
                Console.WriteLine("Reading data from file.....\n ");
                Console.WriteLine(RNo);
                Console.WriteLine(name);
                Console.WriteLine(M);
                Console.WriteLine(P);
                Console.WriteLine(C);
               
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
