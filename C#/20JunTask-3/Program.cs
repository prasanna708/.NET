using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _20JunTask_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Accept 4 elements (2X2 matrix) first Matrix A and
            //4 elements into Matrix B and displaymultiplication of two matrices(A* B)

            // A matrix
            int[,] A = new int[2,2];
            Console.WriteLine("Enter Matrix-A elements: ");
            int i, j;
            for (i = 0; i < 2; i++)
            { 
                for (j = 0; j < 2; j++)
                {
                    A[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // B matrix
            int[,] B = new int[2, 2];
            Console.WriteLine("Enter Matrix-B elements: ");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    B[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //Product of Matrices
            int[,] product = new int[2, 2];
            int k;
            for (i = 0;i < 2; i++)
            {
                for(j = 0;j < 2; j++)
                {
                    product[i, j] = 0;
                    for(k = 0;k < 2; k++)
                    {
                        product[i,j]+= A[i,k] * B[k,j];
                    }
                }
            }

            //Displaying Matrix-A
            Console.WriteLine("Matrix-A is: ");
            for(i = 0; i < 2 ; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write(A[i, j] + "\t");
                }
                Console.WriteLine();
            }

            //Displaying Matrix-B
            Console.WriteLine("Matrix-B is: ");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write(B[i, j] + "\t");
                }
                Console.WriteLine();
            }

            //Displaying Product
            Console.WriteLine("Product matrix is: ");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write(product[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
