using System;

namespace DocGhiFile2_TryCatch
{
    class Program
    {

        static void Main(String[] args)
        {
            string file1 = @"D:\check2.txt";
            string file2 = @"D:\check2copy.txt";
            StreamWriter sw = File.AppendText(file2);
            //sw.WriteLine("\nDay la dong de kiem tra");
            //sw.Close();
            try
            {
                string str1 = "";
                StreamReader sr = new StreamReader(file1);
                str1 = sr.ReadToEnd();
                sw.WriteLine(str1);
                sw.Close();
                string line1;
                while((line1 = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line1);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }

    }
}