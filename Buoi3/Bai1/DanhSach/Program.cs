using System;

namespace DanhSach
{
    class Program
    {
        static void Main(String[] avgs)
        {
            List<double> li = new List<double>();
            for(int i = 0; i < 5; i++)
            {
                double num;
                num = double.Parse(Console.ReadLine());
                li.Add(num);
            }
            //li.Sort();
            for(int i = 0; i < li.Count-1; i++)
            {
                for (int j = i + 1; j < li.Count; j++)
                {
                    if (li[i] > li[j])
                    {
                        double tg = li[i];
                        li[i] = li[j];
                        li[j] = tg;
                    }
                }
            }
            for(int i = 0; i < li.Count; i++)
            {
                Console.Write(li[i] + " ");
            }

            //xóa số âm trong list
            for(int i = 0; i < li.Count; i++)
            {
                if (li[i] < 0)
                {
                    li.RemoveAt(i);
                    i--;
                }
            }
            Console.WriteLine();
            for (int i = 0; i < li.Count; i++)
            {
                Console.Write(li[i] + " ");
            }

            int x, k;
            Console.WriteLine("Nhap so va vi tri can chen: ");
            x = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            li.Insert(k, x);
            Console.WriteLine();
            for (int i = 0; i < li.Count; i++)
            {
                Console.Write(li[i] + " ");
            }
        }
    }
}