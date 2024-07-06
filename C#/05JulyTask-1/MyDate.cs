using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05JulyTask_1
{
    internal class MyDate
    {
        private int _dd,_mm,_yy;

        public MyDate()
        {
            _dd = 1;
            _mm = 1;
            _yy = 2024;
        }

        public MyDate(int _dd, int _mm)
        {
            this._dd = _dd;
            this._mm = _mm;
            _yy = 2024;
        }

        public MyDate(int _dd, int _mm, int _yy)
        {
            this._dd = _dd;
            this._mm= _mm;
            this._yy= _yy;
        }

        public void Display()
        {
            Console.WriteLine(_dd + "/" + _mm + "/" +_yy);
        }
    }
}
