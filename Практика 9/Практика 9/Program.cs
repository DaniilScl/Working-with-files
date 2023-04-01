using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;



namespace Практика_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using (StreamWriter sw = File.CreateText("C:\\Users\\AkiWeb\\Desktop\\TestFile3.txt"))
            //{
            //    sw.WriteLine(Console.ReadLine());
            //    sw.WriteLine(Console.ReadLine());
            //    sw.WriteLine(Console.ReadLine());
            //}
            //StreamWriter file = new StreamWriter("C:\\Users\\AkiWeb\\Desktop\\TestFile.txt");
            //file.Write("текст");
            //file.Close();
            Test();
            /// Сделанно 19 из 20
            
        }
        private static void Test()
        {
            char A = char.Parse(Console.ReadLine());
            int k = 0;
            foreach (string i in System.IO.File.ReadAllLines("C:\\Users\\AkiWeb\\Desktop\\TestFile.txt"))
            {
                if (i != null && i.Length > 0 && i[0] == A)
                    k++;



            }
            Console.WriteLine(k);
            
        }
        private static void Test1()
        {
            char A = char.Parse(Console.ReadLine());
            int k = 0;
            foreach (string i in System.IO.File.ReadAllLines("C:\\Users\\AkiWeb\\Desktop\\TestFile.txt"))
            {
                if (i != null && i.Length > 0 && i[i.Length - 1] == A && i[0] == A)
                    k++;



            }
            Console.WriteLine(k);
           

        }
        private static void Test2()
        {

            string maxL = "";
            int k = 0;
            StreamReader f = new StreamReader("C:\\Users\\AkiWeb\\Desktop\\TestFile.txt");
            for (string s = ""; s != null; s = f.ReadLine())
                if (s.Length > maxL.Length)
                    maxL = s;
            k++;

            Console.WriteLine("{0}  {1}",
            maxL, k);

        }
        private static void Test3()
        {
            int k = 0;
            string[] lines = System.IO.File.ReadAllLines("C:\\Users\\AkiWeb\\Desktop\\TestFile.txt");
            int minLength = lines.Min(x => x.Length);
            var resultLines = lines.Where(x => x.Length == minLength).ToList();
            foreach (var item in resultLines)
            {
                k++;
                Console.WriteLine(item);

            }
            Console.WriteLine("Количество маленьких строк: " + k);

        }
        private static void Test4()
        {


            Console.WriteLine(System.IO.File.ReadAllLines("C:\\Users\\AkiWeb\\Desktop\\TestFile.txt").Select((x, i) => (a: x.Length , b: i + 1)).OrderByDescending(x => x.a).First().b);
            Console.ReadKey();

        }
        private static void Test5()
        {

            var lines = File.ReadAllLines("C:\\Users\\AkiWeb\\Desktop\\TestFile.txt").ToList();
            var min = lines.FindIndex(x => x.Length == lines.Min(z => z.Length)) + 1;

            Console.WriteLine(min);
            Console.ReadKey();


        }
        private static void Test6()
        {
            Console.Write("Введите заданную букву: ");
            string a = char.Parse(Console.ReadLine()).ToString();

            StreamReader reader = new StreamReader("C:\\Users\\AkiWeb\\Desktop\\TestFile.txt");


                while (!reader.EndOfStream)
                {
                    string s = reader.ReadLine();
                    if (s.StartsWith(a))
                    {
                        

                        Console.WriteLine(s);
                    }
                }
            

            Console.ReadKey();


        }
        private static void Test7()
        {
            string fileName = "C:\\Users\\AkiWeb\\Desktop\\TestFile.txt";
            string[] lines = File.ReadAllLines(fileName);
            foreach (string line in lines)
                Console.WriteLine(line[0]);


        }
        private static void Test8()
        {

            Console.Write("k1= ");
            int k1 = int.Parse(Console.ReadLine());
            Console.Write("k2= ");
            int k2 = int.Parse(Console.ReadLine());
            string str;
            StreamReader sr = new StreamReader("C:\\Users\\AkiWeb\\Desktop\\TestFile.txt");
            str = sr.ReadLine();
            int s = 0;
            int s1 = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == k1)
                    s = i;
                if (str[i] == k2)
                    s1 = i;
            }

            for (int i = 0; i < str.Length; i++)
            {
                if (s >= k1 && s1 <= k2)
                {
                    Console.WriteLine(str[i]);
                }

            }
            

        }
        private static void Test9()
        {

            string[] lines = File.ReadAllLines("C:\\Users\\AkiWeb\\Desktop\\TestFile.txt");
            int n = int.Parse(Console.ReadLine());
            while (n < lines.Length)
            {
                if (n % 2 != 0)
                {
                    Console.WriteLine(lines[n - 1]);
                    break;
                }
                Console.WriteLine("Строка чётная");
                break;
            }
            Console.ReadKey();

        }
        private static void Test10()
        {

            StreamReader fs = new StreamReader("C:\\Users\\AkiWeb\\Desktop\\TestFile.txt");
            string text = "";
            Console.WriteLine("В данном файле строки, имеющие пробел: ");
            while (true)
            {
                
                string temp = fs.ReadLine();

                if (temp == null) break;
                if (temp.Contains(' '))
                    Console.WriteLine(temp);


                text += temp;
            }
            Console.WriteLine(text);
            Console.ReadLine();

        }
        private static void Test11()
        {
            int length = int.Parse(Console.ReadLine());
            StreamReader sr = new StreamReader("C:\\Users\\AkiWeb\\Desktop\\TestFile.txt");
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                if(line.Length == length)
                    Console.WriteLine(line);
            }

        }
        private static void Test12()
        {
            int length = int.Parse(Console.ReadLine());
            StreamReader sr = new StreamReader("C:\\Users\\AkiWeb\\Desktop\\TestFile.txt");
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                if (line.Length < length)
                    Console.WriteLine(line);
            }

        }
        private static void Test13()
        {
            int k1 = int.Parse(Console.ReadLine());
            int k2 = int.Parse(Console.ReadLine());
            StreamReader sr = new StreamReader("C:\\Users\\AkiWeb\\Desktop\\TestFile.txt");
            string curline;
            int counter = 0;
            while ((curline = sr.ReadLine()) != null)
            {
                counter += 1;
                if (counter > k1 && counter < k2)
                    Console.WriteLine(curline);


            }

        }
        private static void Test14()
        {
            var file = new StreamReader("C:\\Users\\AkiWeb\\Desktop\\TestFile.txt");
            string str, word = "";
            int k = 1;

            while (!file.EndOfStream)
            {
                str = file.ReadLine();
                word += ((k < str.Length) ? str[k] : ' ');
            }

            file.Close();
            Console.WriteLine(word);
            Console.ReadKey();

        }
        private static void Test15()
        {
            

            using (StreamReader sr = File.OpenText("C:\\Users\\AkiWeb\\Desktop\\TestFile.txt"))
            using (var sw = new StreamWriter("C:\\Users\\AkiWeb\\Desktop\\TestFile2.txt"))
            {
                var i = 0;
                while (!sr.EndOfStream)
                {
                    string s = sr.ReadLine();
                    sw.WriteLine($"{++i}. {s} ");
                }
            }

            Console.ReadKey(true);

        }
        private static void Test16()
        {


            using (StreamReader sr = File.OpenText("C:\\Users\\AkiWeb\\Desktop\\TestFile.txt"))
            using (var sw = new StreamWriter("C:\\Users\\AkiWeb\\Desktop\\TestFile2.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string s = sr.ReadLine();
                    sw.WriteLine($" {s} ");
                    sw.WriteLine(s.Length);
                    
                } 
            }

        }
        private static void Test17()
        {

            int n = int.Parse(Console.ReadLine());
            using (StreamReader sr = File.OpenText("C:\\Users\\AkiWeb\\Desktop\\TestFile.txt"))
            using (var sw = new StreamWriter("C:\\Users\\AkiWeb\\Desktop\\TestFile2.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    if (line.Length >= n)
                    {
                        string s = sr.ReadLine();
                        sw.WriteLine($" {s} ");
                    }

                }
            }

        }
        
    }
}
