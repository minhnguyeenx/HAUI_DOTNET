using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoanThiThuy_2020603329_proj61
{
    class Person
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }

        public virtual void input() {
            Console.Write("Nhap id: ");
            id = int.Parse(Console.ReadLine());
            Console.Write("Nhap name: ");
            name = Console.ReadLine();
            Console.Write("Nhap address: ");
            address = Console.ReadLine();
        }
        
        public virtual void output()
        {
            Console.Write($"{id,5}{name,20}{address,20}");
        }
    }
}
