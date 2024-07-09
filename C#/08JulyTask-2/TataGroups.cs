using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08JulyTask_2
{
    class TataGroups    //first class (Parent class)
    {
        private string _Address;

        public TataGroups()
        {
            _Address = "Bombay House, 24, Homi Modi Street, Fort, Mumbai - 400001 (Opposite Central Bank Of India)";
        }

        ~TataGroups() { }

        public void HeadOfficeAddress()
        {
            Console.WriteLine("Address of Head Office : "+_Address);
        }
    }

    class TataMotors : TataGroups   //second class inheriting 1st class (1st child)
    {
        public TataMotors()
        {
            
        }

        ~TataMotors() { }

        public void Business()
        {
            Console.WriteLine("Tata Motors..........");
        }
    }

    class TCS : TataGroups      //third class inheriting 1st class (2nd child)
    {
        public TCS()
        {
            
        }

        ~TCS() { }

        public void Business()
        {
            Console.WriteLine("TCS.........");
        }
    }
}
