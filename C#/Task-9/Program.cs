using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
          /*  Task#3.
            I/ P: welcome to india
            o / p: emoclew ot aidni */
            string words = "Welcome to India";
            String[] Words = words.Split(' ');
            //Iterating each word
            for (int i = 0; i < Words.Length; i++) { 
                Console.Write(Words[i] + " ");
            }
            Console.WriteLine();
            //Reversing words
            for (int i = Words.Length-1; i >= 0; i--) {
                Console.Write(Words[i] + " ");
            }
            Console.WriteLine();
            //Reversing each word
            for (int i = Words[0].Length - 1; i >= 0; i--)
            {
                Console.Write(Words[0][i]); 
            }
            Console.Write(" ");
            for (int i = Words[1].Length - 1; i >= 0; i--)
            {
                Console.Write(Words[1][i]);
            }
            Console.Write(" ");
            for (int i = Words[2].Length - 1; i >= 0; i--)
            {
                Console.Write(Words[2][i]);
            }


            Console.ReadKey();
        }
    }
}
