using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _25JunTask_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Do a program to implement t20 match.Where we have 20 overs
            //and in each every over wehave 6 balls and then you need to
            //take score of first innings for 10 wickets and then you need
            //to takesecond innings score finally display the winner.At the
            //end of it you need to display score board for eachteam.

            int[,] TeamA = new int[2,6];
            int[,] TeamB = new int[2,6];

            //Team-A Score

            int i, j;
            for (i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter Over "+(i+1)+ " score:" );
                for (j = 0; j < 6; j++)
                {
                    Console.WriteLine("Enter score for ball "+(j+1)+" :");
                    TeamA[i,j] = Convert.ToInt32(Console.ReadLine());
                }

            }

            //calculating score for each over and innings score 
            int overscoreA = 0;
            int inn1score;
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 6; j++)
                {
                    overscoreA+= TeamA[i,j];
                }
                Console.WriteLine("Score for over-" + (i + 1)+ " is :" +overscoreA);

            }
            inn1score = overscoreA++; 
            Console.WriteLine( "Total score is: "+inn1score);


            //Team-B Score

            //TeamA Score

            for (i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter Over " + (i + 1) + " score:");
                for (j = 0; j < 6; j++)
                {
                    Console.WriteLine("Enter score for ball " + (j + 1) + " :");
                    TeamB[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }

            //calculating score for each over and innings score 
            int overscoreB = 0;
            int inn2score;
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 6; j++)
                {
                    overscoreB += TeamB[i, j];
                }
                Console.WriteLine("Score for over-" + (i + 1) + " is :" + overscoreB);

            }
            inn2score = overscoreB++;
            Console.WriteLine("Total score is: " + inn2score);

            int diff1 = inn1score - inn2score;
            int diff2 = inn2score - inn1score;
            if (inn1score > inn2score)
                Console.WriteLine("Team-A Wins The Match with "+diff1+ " runs");
            else 
                Console.WriteLine("Team-B Wins The Match with "+diff2+" runs");



            Console.ReadKey();
        }
    }
}
