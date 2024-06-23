using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _22JunTask_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //three dim array demo1
            // 2 semesters, 3 subjects and 2 papers
            int[,,] marks = new int[2, 3, 2];
            int i, j, k;
            // Console.WriteLine(&quot;enter marks in 12 subjects :&quot;);
            for (i = 0; i < 2; i++)//sems
            {
                Console.WriteLine("enter marks for Sem " +(i + 1)) ;
                for (j = 0; j < 3; j++)//subjects
                {
                    if (j == 0)
                        Console.WriteLine("Maths: ");
                    else if (j == 1)
                        Console.WriteLine("Physics: ");
                    else
                        Console.WriteLine("Chemistry: ");
                    for (k = 0; k < 2; k++)// papers
                    {
                        if (k == 0)
                            Console.Write("Paper 1: ");
                        else
                            Console.Write("Paper 2: ");
                        marks[i, j, k] = Convert.ToInt32(Console.ReadLine());

                    }//end of papers
                }//end of subjs
            }//end of sems


            //Semester wise total and average
            for (i = 0; i < 2; i++)//sems
            {
                double tot = 0;
                for (j = 0; j < 3; j++)//subjects
                {
                    

                    for (k = 0; k < 2; k++)// papers
                    {
                        tot += marks[i, j, k]; 

                    }
                }

                double avg = tot / 3;
                Console.WriteLine("\n" + "Details of student " + (i + 1));
                Console.WriteLine("Total marks:" + tot);
                Console.WriteLine("Average marks:" + avg);

            }



            Console.ReadKey();


        }
    }
}
