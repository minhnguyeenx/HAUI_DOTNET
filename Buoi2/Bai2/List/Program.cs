using System;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List <string> strings = new List <string> ();
            for (int i = 0; i < 5; i++)
            {
                string str = Console.ReadLine();
                strings.Add (str);
            }
            strings.Sort();
            foreach (string str in strings)
            {
                Console.WriteLine(str);
            }
            strings.Remove("Ha Noi");
            Console.WriteLine(String.Join(", ", strings));
            for (int i = 0; i < 5; i++)
            {
                string str = Console.ReadLine();
                strings.Add(str);
            }
            Console.WriteLine(String.Join(", ", strings));
        }
    }
}