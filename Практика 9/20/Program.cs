using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            StreamReader text = new StreamReader("C:\\Users\\AkiWeb\\Desktop\\TestFile.txt");
            var sw = new StreamWriter("C:\\Users\\AkiWeb\\Desktop\\TestFile2.txt");
            string line = text.ReadLine();
            string str = "";

            for (int i = 0; i < line.Length; i++)
            {
                if (i % 2 != 0)
                    str += line.Length;

            }
            sw.WriteLine(str);

        }
    }
}
