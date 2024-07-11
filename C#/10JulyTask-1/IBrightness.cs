using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _10JulyTask_1
{   
    //Creating interface and inheriting interface to classes
    internal interface IBrightness  //interface
    {
        void IncBrightness();
        void DecBrightness();
    }

    class Mobile : IBrightness  //class inheriting interface
    {
        
        public void DecBrightness()
        {
            Console.WriteLine("Mobile:");
            Console.WriteLine("Press down-key to drcrease volume.....");
        }

        public void IncBrightness()
        {
            Console.WriteLine("Press up-key to increase brightness.....");
        }
    }

    class Laptop : IBrightness  //class inheriting interface
    {
        public void DecBrightness()
        {
            Console.WriteLine("laptop:");
            Console.WriteLine("Press f3 to Decrease Brightness.....");
        }

        public void IncBrightness()
        {
            Console.WriteLine("Press f4 to Increase Brightness.....");
        }
    }
}
