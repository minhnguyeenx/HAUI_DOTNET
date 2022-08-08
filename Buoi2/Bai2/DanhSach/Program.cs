using System;

namespace DanhSach
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for(int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < n; i++)
            {
                if (a[i] % 2 == 0) Console.Write(a[i] + " ");
            }
            Console.WriteLine("");
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 != 0) Console.Write(a[i] + " ");
            }
            Console.WriteLine("");
            for(int i = 0; i < n; i++)
            {
                if (sont(a[i]) != -1) Console.Write(a[i] + " ");
            }
        }
        public static int sont(int num)
        {
            if (num < 2) return -1;
            for(int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) return -1;
            }
            return num;
        }
    }
}