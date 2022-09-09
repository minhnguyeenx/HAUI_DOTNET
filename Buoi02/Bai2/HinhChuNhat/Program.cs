using System;

namespace HinhChuNhat
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = Convert.ToDouble(Console.ReadLine());
            double width = Convert.ToDouble(Console.ReadLine());
            double p, s;
            p = 2 * (length + width);
            s = length * width;
            Console.WriteLine($"Chu vi hinh chu nhat: {p}");
            Console.WriteLine($"Dien tich hinh chu nhat: {s}");
        }
    }
}