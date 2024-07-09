using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08JulyTask_1
{
    class School
    {
        private string _Stuname;
        private int _RNO;
        private string _class;
        private char _sec;
        private int _Fee;
        public School()
        {
            _Stuname = "Prasanna Kumar";
            _RNO = 1;
            _class = "10th";
            _sec = 'A';
            _Fee = 15000;
        }

        ~School()
        {

        }

        public void SchoolDetails()
        {
            Console.WriteLine("Student Name : "+_Stuname);
            Console.WriteLine("Student Roll No : " + _RNO);
            Console.WriteLine("Student Class : " + _class);
            Console.WriteLine("Student Section : " + _sec);
            Console.WriteLine("Student's School Fee : "+_Fee);
        }  
    }
}
