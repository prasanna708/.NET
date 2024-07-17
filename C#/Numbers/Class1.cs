using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    public class MyClass
    {
            private int _num;
            public MyClass()
            {
                _num = 0;
            }
            public MyClass(int num)
            {
                _num = num;
            }
            public void Accept(int num)
            {
                _num = num;
            }
            //Even or Odd number
            public bool IsEven()
            {
                if (_num % 2 == 0)
                    return true;
                else
                    return false;
            }
            //Palindrome number
            public bool IsPalindrome()
            {
                int rev = 0;
                int temp = _num;
                while (temp > 0)
                {
                    int rem = temp % 10;
                    rev = rev * 10 + rem;
                    temp = temp / 10;
                }
                return rev == _num;
            }
            //Armstrong number
            public bool IsArmstrong()
            {
                double sum = 0;
                int temp = _num;
                int count = 0;
                while (temp > 0)
                {
                    count++;
                    temp = temp / 10;
                }
                temp = _num;
                while (temp > 0)
                {
                    int r = temp % 10;
                    sum += Math.Pow(r, count);
                    temp = temp / 10;
                }
                return sum == _num;
            }

        
    }
}

