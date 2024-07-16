using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15JulyTask_1
{
    internal class Program
    {
        //Working with non generic collections(array list)
        private static object arraylist;
        static void DisplayElements(ArrayList ar)
        {
            foreach (var element in ar)
            {
                Console.WriteLine(element);
            }
        }
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();  //creating arraylist
            al.Add(100);      //adding elements to arraylist
            al.Add("Poul");
            al.Add(20000);
            Console.WriteLine("Elements in al: ");
            DisplayElements(al);    //calling method to print arraylist elements

            al.Insert(2, "John");   //inserting into arraylist
            Console.WriteLine("Elements in al after inserting John: ");
            DisplayElements(al);

            al.Remove("Poul");  //Removing from arraylist
            Console.WriteLine("Elements in al after removing Poul: ");
            DisplayElements(al);

            al.RemoveAt(0);     //Removing from arraylist using index
            Console.WriteLine("Elements in al after remove at 0 index: ");
            DisplayElements(al);

            Console.ReadKey();
        }
    }
}
