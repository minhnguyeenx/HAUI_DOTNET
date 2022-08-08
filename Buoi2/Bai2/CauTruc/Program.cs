using System;

namespace CauTruc
{
    class Program
    {
        static void Main(string[] args)
        {
            Hocsinh[] hsmoi = new Hocsinh[5];
            for(int i = 0; i < 5; i++)
            {
                hsmoi[i].Hoten = Console.ReadLine();
                hsmoi[i].Tuoi = Convert.ToInt32(Console.ReadLine());
                hsmoi[i].Gioitinh = Console.ReadLine();
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ho va ten: " + hsmoi[i].Hoten);
                Console.WriteLine("Gioi tinh: " + hsmoi[i].Gioitinh);
                Console.WriteLine("Tuoi: " + hsmoi[i].Tuoi);
            }
        }
        
        public struct Hocsinh
        {
            public string Hoten;
            public int Tuoi;
            public string Gioitinh;
        }
    }
}