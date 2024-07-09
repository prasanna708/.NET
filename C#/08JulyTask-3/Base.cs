using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08JulyTask_3
{
    class Base      //1st class (parent class)
    {
        public void Parent()    
        {
            Console.WriteLine("Base Class.......");
        }     
    }

    class Super:Base       //2nd class inheriting 1st class (child class)
    {
        public void Child()
        {
            Console.WriteLine("Super Class.......");
        }
    }

    class Sub:Super     //3rd class inheriting 2nd class (grand child)
    {
        public void GrandChild()
        {
            Console.WriteLine("Sub Class.......");
        }
    }

}
