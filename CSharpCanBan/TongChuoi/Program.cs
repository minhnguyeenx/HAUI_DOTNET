using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TongChuoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhap n: ");
            n = Convert.ToInt32(Console.ReadLine());
            int Sa = 0;
            double Sb = 0.0;
            //Sa = ((n+1)*n)/2
            for (int i = 1; i <= n; i++)
            {
                Sa += i;
            }
            for (int i = 1; i <= n; i++)
            {
                Sb += (double)1 / i;
            }
            //Console.WriteLine("Sa = {0}", Sa);
            //Console.WriteLine("Sb = {0}", Sb);
            Console.WriteLine("Sa = {0}", Sa);
            Console.WriteLine("Sb = {0}",Sb);
        }
    }
}
