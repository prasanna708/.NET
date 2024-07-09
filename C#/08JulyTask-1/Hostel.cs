using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08JulyTask_1
{
    class Hostel : School
    {
        private int _Hfee;
        private string _MName;
        private string _FName;
        private string _Address;
        public Hostel()
        {
            _Hfee = 10000;
            _MName = "Jyothi";
            _FName = "Satyanarayana";
            _Address = "D.No:11-127, Sivalayam Street, Enikepadu, Vijayawada-521108";
        }
        
        ~Hostel()
        {

        }

        public void HostelDetails()
        {
            Console.WriteLine("Student's Hostel Fee : "+_Hfee);
            Console.WriteLine("Student's Mother Name : " + _MName);
            Console.WriteLine("Student's Father Name : " + _FName);
            Console.WriteLine("Student's Address : " + _Address);
        }
        

    }
}
