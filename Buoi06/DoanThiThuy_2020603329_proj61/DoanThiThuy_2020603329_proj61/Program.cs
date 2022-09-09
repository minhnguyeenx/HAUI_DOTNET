using System;
using System.Collections.Generic;
using DoanThiThuy_2020603329_proj61;

namespace DoanThiThuy_2020603329_proj61
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            int choose;
            List<Student> students = new List<Student>();
            do
            {
                Console.WriteLine("\n____MENU____");
                Console.WriteLine("1. Thêm 1 sinh viên.");
                Console.WriteLine("2. Hiển thị danh sách sinh viên.");
                Console.WriteLine("3. Tìm kiếm sinh viên theo Id");
                Console.WriteLine("4. Tìm kiếm sinh viên theo Adress");
                Console.WriteLine("5. Xóa 1 sinh viên.");
                Console.WriteLine("6. Kết thúc chương trình."); ;
                Console.Write("\nNhập lựa chọn : ");
                choose = int.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        Student x = new Student();
                        Console.WriteLine("\nNhập thông tin : ");
                        x.input();
                        if (!students.Contains(x))
                            students.Add(x);
                        else
                            Console.WriteLine("Sinh viên đã tồn tại!");
                        break;

                    case 2:
                        Console.WriteLine("\nDanh sách sinh viên :");
                        students.ForEach(
                            x =>
                            {
                                x.output();
                            }
                        );
                        break;

                    case 3:
                        int ID;
                        int check3 = 0;
                        Console.Write("\nNhập ID cần tìm : ");
                        ID = int.Parse(Console.ReadLine());
                        students.ForEach(
                            x =>
                            {
                                if (x.id == ID)
                                {
                                    check3 = 1;
                                    Console.WriteLine($"Tìm thấy sinh viên có ID {ID}");
                                    x.output();
                                }
                            }
                            );
                        if (check3 == 0)
                            Console.WriteLine("Không tìm thấy sinh viên!.");

                        break;

                    case 4:
                        string ADDRESS;
                        int check4 = 0;
                        Console.Write("\nNhập ADDRESS cần tìm : ");
                        ADDRESS = Console.ReadLine();
                        students.ForEach(
                            x =>
                            {
                                if (x.address == ADDRESS)
                                {
                                    check4 = 1;
                                    Console.WriteLine($"Tìm thấy sinh viên có ADDRESS {ADDRESS}");
                                    x.output();
                                }
                            }
                            );
                        if (check4 == 0)
                            Console.WriteLine("Không tìm thấy sinh viên!.");
                        break;

                    case 5:
                        int ID5, check5 = 0;
                        Console.WriteLine("\nNhập ID sinh viên cần xóa : ");
                        ID5 = int.Parse(Console.ReadLine());
                        Student temp = new Student();
                        students.ForEach(
                            x =>
                            {
                                if (x.id == ID5)
                                {
                                    check5 = 1;
                                    temp = x;
                                    return;
                                }
                            }
                        );

                        students.Remove(temp);

                        Console.WriteLine("\nDanh sách sau khi xóa : ");
                        students.ForEach(
                            x => x.output()
                        );

                        if (check5 == 0)
                            Console.WriteLine("Không tìm thấy sinh viên, thao tác lại !");
                        break;

                    case 6:
                        Console.WriteLine("\nChương trình đã kết thúc!");
                        return;
                        break;

                    default:
                        break;
                }
            }
            while (true);
        }
    }

}
