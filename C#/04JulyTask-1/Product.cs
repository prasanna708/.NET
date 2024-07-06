using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04JulyTask_1
{
    internal class Product
    {
        private int _Pid;
        private string _PName;
        private double _Price;

        public Product()    //Default Constructor
        {
            Console.WriteLine("Default Constructor invoked......!!!");
            _Pid = 0;
            _PName = string.Empty;
            _Price = 0;
        }

        public Product(int _Pid, string _PName, double _Price)  //Parameteraized Constructor
        {
            Console.WriteLine("Parameteraized Constructor invoked.....!!!");
            this._Pid = _Pid;
            this._PName = _PName;   
            this._Price = _Price;
        }

        public void Display()
        {
            Console.WriteLine("Product ID: "+_Pid);
            Console.WriteLine("Product Name: "+_PName);
            Console.WriteLine("Product Price: "+_Price);  
        }

    }
}
