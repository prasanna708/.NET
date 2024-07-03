using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27Juntask_2
{
    internal class Program
    {
        //Reading binary data
        static void Main(string[] args)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\files\binarydata.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                int a;
                string b;
                double c;
                a = br.ReadInt32();
                b = br.ReadString();
                c = br.ReadDouble();

                Console.WriteLine("Reading binary data");

                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);

                br.Close();
                fs.Close();
            }
            catch (FileNotFoundException f)
            {
                Console.WriteLine(f.Message);
            }

        }
    }
}
