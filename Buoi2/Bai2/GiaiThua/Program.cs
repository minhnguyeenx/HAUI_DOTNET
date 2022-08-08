using System;

namespace GiaiThua
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 1) Console.WriteLine(1);
            else
            {
                long tich = 1;
                for(int i = 2; i <= n; i++)
                {
                    tich *= i;
                }
                Console.WriteLine(tich);
            }
        }
    }
}