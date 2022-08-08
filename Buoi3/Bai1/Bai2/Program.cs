using System;

namespace Bai3_2
{
    class Program
    {
        static void Main(String[] avgs)
        {
            double a, b;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            int choose;
            do
            {
                Console.WriteLine("Nhap phep toan + - * /: ");
                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Console.WriteLine($"{a} + {b} = {a + b}");
                        break;
                    case 2:
                        Console.WriteLine($"{a} - {b} = {a - b}");
                        break;
                    case 3:
                        Console.WriteLine($"{a} * {b} = {a * b}");
                        break;
                    case 4:
                        Console.WriteLine($"{a} / {b} = {(double)(a / b)}");
                        break;
                }
            } while(choose < 5);
        }
    }
}