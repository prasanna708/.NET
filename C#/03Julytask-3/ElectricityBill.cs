using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _03Julytask_3
{
    internal class ElectricityBill
    {
        private int _Meterno;
        private string _Custname;
        private int PrevReading, currReading;
        private int _Units;
        private double _Price;
        private double _BillAmount;

        internal void CustomerDetalis(int id, string name)
        {
            _Meterno = id;
            _Custname = name;
        }

        internal void CalculateBill(int x, int y,int p)
        {
            currReading = x;
            PrevReading = y;
            _Price = p;
            _Units = currReading - PrevReading;
            _BillAmount = _Units * _Price;
        }

        internal void Display()
        {
            Console.WriteLine("Meter number: " + _Meterno);
            Console.WriteLine("Name of the Customer: " + _Custname);
            Console.WriteLine("Total units Used: " + _Units);
            Console.WriteLine("Total Electricity Bill Amount: " + _BillAmount);
        }

    }


}
