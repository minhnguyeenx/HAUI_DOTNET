using System;

namespace DocGhiFile1
{
    class Program
    {
        static void Main(String[] args)
        {
            //copy ra file có sẵn
            /*string file1 = @"D:\check1.txt";
            string file1copy = @"D:\check1copy.txt";
            File.Copy(file1, file1copy);*/

            //1. Đọc 1 file rồi hiển thị nội dung ra màn hình
            //2. Sau khi đọc file thì ghi nội dung file đó ra 1 file khác
            string str1 = "";
            string file2 = @"D:\check1.txt";
            StreamReader sr = new StreamReader(file2);
            str1 = sr.ReadToEnd();
            Console.WriteLine(str1);
            
            string file3 = @"D:\check1copy2.txt";
            StreamWriter sw = new StreamWriter(file3);
            sw.Write(str1);
            sw.Close(); // quan trọng, nhớ close lại thì mới ghi file được

            //Thêm chữ vào 1 file
            string file4 = @"D:\checkappend.txt";
            StreamWriter sw2 = File.AppendText(file4);
            sw2.WriteLine("\nDay la dong duoc them 1");
            sw2.Close();
        }
    }
}
