using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamGiac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Nhap canh a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap canh b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap canh c: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Cac canh cua tam giac la: {a}, {b}, {c}");
            double P;
            P = (a + b + c) / 2;
            Console.WriteLine($"Chu vi tam giac la: {P * 2}");
            double S;
            S = Math.Sqrt(P * (P - a) * (P - b) * (P - c));
            Console.WriteLine($"Dien tich tam giac la: {S}");
        }
    }
}
