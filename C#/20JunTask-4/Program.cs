using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20JunTask_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program to display transpose of the given Matrix.
            int[,] A = new int[,] { { 10, 20, 30 }, { 40, 50, 60 } };
            int i,j;
            Console.WriteLine("Matrix is: ");
            for (i = 0; i < 2; i++) { 
                for (j = 0;  j < 3; j++)
                {
                    Console.Write(A[i, j] + "\t");
                }
                Console.WriteLine();
            }

            //Transpose
            int[,] T = new int[3,2];
            for (i = 0; i < 3; i++) {
                for (j = 0; j < 2; j++)
                {
                    T[i,j] = A[j,i];    
                }
            }

            Console.WriteLine("Transpose of matrix-A is: ");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write(T[i, j] + "\t");
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
