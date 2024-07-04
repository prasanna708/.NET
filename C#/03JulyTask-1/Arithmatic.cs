using System;

namespace _03JulyTask_1
{
    internal class Arithmatic
    {
        private int _num1,_num2,result;

        public void calc(int x, int y)
        {
            _num1 = x; _num2 = y;
            Console.WriteLine("1st number = " +_num1 );
            Console.WriteLine("2nd number = " + _num2 );
        }

        internal void Add()
        {
            result = _num1 + _num2;
            Console.WriteLine("Sum = " + result);
        }

        internal void Difference()
        {
            result = _num1 - _num2;
            Console.WriteLine("Difference = " + result);
        }

        internal void Product()
        {
            result = _num1 * _num2;
            Console.WriteLine("Product = " + result);
        }

        internal void Divide()
        {
            result = _num1 / _num2;
            Console.WriteLine("Quotient = " + result);
        }
            
    }
}