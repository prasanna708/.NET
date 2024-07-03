using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27JunTask_1
{
    internal class Program
    {
        static void BinaryWriter()
        {
            //Binary data file creation and writing into binary file
            try
            {
                FileStream fs = new FileStream(@"D:\files\binarydata.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                Console.WriteLine("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a string: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter double value: ");
                double db = Convert.ToDouble(Console.ReadLine());

                bw.Write(num);
                bw.Write(name);
                bw.Write(db);

                Console.WriteLine("File created successfully.......");

                bw.Flush();
                bw.Close();
                fs.Close();
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Main(string[] args)
        {
            BinaryWriter();
            Console.ReadKey();
        }
    }
}
