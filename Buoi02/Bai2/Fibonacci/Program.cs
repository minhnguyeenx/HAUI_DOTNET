using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            int fibo = new int[n];
            fibo[0] = 0;
            fibo[1] = 1;
            Console.Write(fibo[0] + " " + fibo[1] + " ");
            for(int i = 2; i < n; i++)
            {
                fibo[i] = fibo[i - 1] + fibo[i - 2];
                Console.Write(fibo[i] + " ");
            }
        }
    }
}