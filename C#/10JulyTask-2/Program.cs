using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10JulyTask_2
{
    internal class Program
    {
        interface IKeyEvents
        {
            void Enter();
            void Esc();
        }

        interface IMouseEvents
        {
            void SingleClick();
            void DoubleClick();
        }

        class Application : IKeyEvents, IMouseEvents
        {
            public void Enter()
            {
                Console.WriteLine("Keyboard Events:");
                Console.WriteLine("Press Enter key to open application.....");
            }
            public void Esc()
            {
                Console.WriteLine("Press Esc key to exit application.....");
            }

            public void SingleClick()
            {
                Console.WriteLine("Mouse Events:");
                Console.WriteLine("Click once to open files.....");
            }
            public void DoubleClick()
            {
                Console.WriteLine("double click to see more options.....");
            }
          
        }
        static void Main(string[] args)
        {
            Application app = new Application();    
            app.Enter();
            app.Esc();
            app.SingleClick();
            app.DoubleClick();

            Console.ReadKey();
        }
    }
}
