using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6Phieu1
{
    class Student : Person
    {
        public float math { get; set; }
        public float physics { get; set; }

        public void Input()
        {
            base.Input();
            Console.Write("Math : ");
            math = float.Parse(Console.ReadLine());
            Console.Write("Physics : ");
            physics = float.Parse(Console.ReadLine());
        }

        public float Total()
        {
            return math + physics;
        }

        public void Output()
        {
            base.Output();
            Console.Write($"{math,-6} {physics,-6} {this.Total(),-8}\n");
        }

        public override bool Equals(object obj)
        {
            Student x = (Student)obj;
            return x.id.Equals(this.id);
        }
    }
}
