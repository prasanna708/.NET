using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _20JunTask_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Accept 4 elements(2X2 matrix) first Matrix A and 4
           // elements into Matrix B and display difference of two matrices(A-B)

            //matrix-1
            int[,] Mat1 = new int[2, 2];
            Console.WriteLine("Enter matrix-1 elements:");
            int i, j;
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Mat1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //matrix-2
            int[,] Mat2 = new int[2, 2];
            Console.WriteLine("Enter matrix-2 elements:");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Mat2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //Difference of matrices
            int[,] sum = new int[2, 2];

            Console.WriteLine("Sum of two matrices are: ");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    sum[i, j] = Mat1[i, j] - Mat2[i, j];
                }
            }

            //displaying matrix-1
            Console.WriteLine("Matrix-1 is: ");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write(Mat1[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }

            //displaying matrix-2
            Console.WriteLine("Matrix-2 is: ");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write(Mat2[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }

            //displaying Difference
            Console.WriteLine("sum is: ");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write(sum[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }

            Console.ReadKey();
        }
    }
}
