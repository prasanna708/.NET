using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08JulyTask_3
{
    //MultiLevel Inheritence
    internal class Program
    {
        static void Main(string[] args)
        {
            Sub sub = new Sub();
            //sub obj contains methods of both 1st and 2nd class.

            sub.Parent();
            sub.Child();
            sub.GrandChild();

            Console.ReadKey();
        }
    }
}
