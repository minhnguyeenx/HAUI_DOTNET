using System;

namespace TaoDocFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //copy file có sẵn
            //string PathToFile = @"D:\HOCKY5\LAPTRINHDOTNET\Buoi2\Thu1.txt";
            //string PathToFileCopy1 = @"D:\HOCKY5\LAPTRINHDOTNET\Buoi2\Thu2.txt";
            //File.Copy(PathToFile, PathToFileCopy1);

            //tạo file mới rồi copy
            string PathToFile2 = @"D:\HOCKY5\LAPTRINHDOTNET\Buoi2\Thu3.txt";
            TextWriter writer = new StreamWriter(PathToFile2);
            writer.WriteLine("Dong 1");
            writer.Flush();
            writer.Close(); 
            string PathToFileCopy2 = @"D:\HOCKY5\LAPTRINHDOTNET\Buoi2\Thu4.txt";
            File.Copy(PathToFile2, PathToFileCopy2);

            //StreamReader và StreamWriter
            
            //Read Everything From File with ReadAllText Function in C#
            string text = File.ReadAllText(PathToFile2);
            Console.WriteLine(text);
        }
    }
}