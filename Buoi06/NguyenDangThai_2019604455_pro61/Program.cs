using System;

namespace Bai1
{
	class Program
    {
		public class Person
		{
			public int id;
			public string name, address;

			public Person(int id, string name, string address)
			{
				this.name = name;
				this.address = address;
			}

			public Person()
			{
				this.id = 1;
				this.name = "Nguyen Dang Thai";
				this.address = "Bac Ninh";
			}

			public void Input()
			{
				Console.WriteLine("ID: ");
				this.id = Int32.Parse(Console.ReadLine());
				Console.WriteLine("Name: ");
				this.name = Console.ReadLine();
				Console.WriteLine("Address: ");
				this.address = Console.ReadLine();
			}

			public void Output()
			{
				Console.WriteLine(this.id + "\n" + this.name + "\n" + this.address);
			}
			public void Label()
			{
				Console.WriteLine("ID\tName\tAddress");
			}
		}
			public class student : Person
			{
				public byte maths;
				public byte physics;

				public void inputStudent()
				{
					Input();
					Console.WriteLine("Nhap diem toan: ");
					maths = byte.Parse(Console.ReadLine());
					Console.WriteLine("Nhap diem ly: ");
					physics = byte.Parse(Console.ReadLine());
				}
				public void outputStudent()
				{
					Output();
					Console.WriteLine("toan\tly");
					Console.WriteLine(this.maths + "\t" + this.physics);
				}
				public void total()
				{
					float kq;
					kq = maths + physics;
					Console.WriteLine("Tong diem: " + kq);
				}
			}
		

		static void Main(string[] args)
		{
			int n;
			int op;
			Console.WriteLine("1. Them mot sinh vien");
			Console.WriteLine("2. Hien thi danh sach sinh vien");
			Console.WriteLine("3. Tim kiem sinh vien theo id");
			Console.WriteLine("4. Tim kiem sinh vien theo address");
			Console.WriteLine("5. Xoa mot sinh vien theo id");
			Console.WriteLine("6. Ket thuc chuong trinh");	
			op = int.Parse(Console.ReadLine());
			switch (op)
            {
				case 1:
					student s = new student();
					s.inputStudent();
					s.outputStudent();
					s.total();
					break;
				case 2:
					Console.WriteLine("Nhap n: ");
					n = int.Parse(Console.ReadLine());
					student[] sv = new student[n];
					break;
			}
		}
	}
}
