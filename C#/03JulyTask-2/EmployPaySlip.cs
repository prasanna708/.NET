using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03JulyTask_2
{
    internal class EmployPaySlip
    {
        private int _empid;
        private string _name;
        private double _basicpay;
        private double TA, DA, HRA, PF, IT;
        private double GrossPay, NetPay;

        public void AcceptEmployDetails(int id, string name, double basicpay)
        {
            _empid = id;
            _name = name;
            _basicpay = basicpay;
        }

        public void CalculateSalary()
        {
            TA = (_basicpay * 10) / 100;
            DA = (_basicpay * 12) / 100;
            HRA = (_basicpay * 15) / 100;
            PF = (_basicpay * 10) / 100;
            IT = (_basicpay * 5) / 100;

            GrossPay = _basicpay + TA + DA + HRA;
            NetPay = GrossPay - (PF + IT) ;
        }

        public void PrintPayslip()
        {
            Console.WriteLine("Employ Id: " +_empid );
            Console.WriteLine("Employ Name: " +_name );
            Console.WriteLine("Basic Pay: " + _basicpay);
            Console.WriteLine("GrossPay: " + GrossPay);
            Console.WriteLine("NetPay: " + NetPay);
        }

    }
}
