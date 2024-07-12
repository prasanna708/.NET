using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11JulyTask_2
{
    internal class Program
    {
        //operator overloading using binary operators
        class Numbers
        {
            private int num;
            public Numbers()
            {
                num = 0;
            }
            public Numbers(int num)
            {
                this.num = num;
            }
            ~Numbers() {    }
            public static Numbers operator +(Numbers a, Numbers b)
            {
                Numbers sum = new Numbers();
                sum.num = a.num + b.num;
                return sum;
            }
            public void Display()
            {
                Console.WriteLine("number is: "+num);
            }
            public override string ToString()   //Using ToString() method
            { 
                return "Sum is: "+num;
            }
        }
        static void Main(string[] args)
        {
            Numbers number1 = new Numbers(100);
            number1.Display();  
            Numbers number2 = new Numbers(200);
            number2.Display();
            Numbers number3 = new Numbers();

            number3 = number1 + number2;
            //number3.Display();
            Console.WriteLine(number3);

            Console.ReadKey();
        }
    }
}
