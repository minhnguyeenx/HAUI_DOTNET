using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoanThiThuy_2020603329_proj61
{
    class Student:Person
    {
        public double maths { get; set; }
        public double physic { get; set; }

        public void input()
        {
            base.input();
            Console.Write("Nhap math: ");
            maths = double.Parse(Console.ReadLine());
            Console.Write("Nhap Physic: ");
            physic = double.Parse(Console.ReadLine());
        }
        public double ToTal()
        {
            return maths + physic;
        }
        public void output()
        {
            base.output();
            Console.Write($"{maths,6}{physic,6}{this.ToTal(),6}\n");
        }
        public override bool Equals(object obj)
        {
            Student x = (Student)obj;
            return x.id.Equals(this.id);
        }
    }
}
