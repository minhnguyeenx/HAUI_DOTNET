using System;

namespace Bai1
{
    class Program
    {
        static void Main(String[] avgs)
        {
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine($"{a} + {b} = {a + b}");
        }
    }
}