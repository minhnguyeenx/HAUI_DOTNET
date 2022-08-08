using System;

namespace HeCoSo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            //ToB(n, b);
            ToDec(n, b);
        }
        public static string Reverse(string s1)
        {
            string s2 = "";
            for(int i = s1.Length - 1; i >= 0; i--)
            {
                s2 += s1[i];
            }
            return s2;
        }
        public static void ToB(int n, int b)
        {
            string ans = "";
            char c;
            while(n > 0)
            {
                c = (char)(n % b + 48);
                ans += c;
                n /= b;
            }
            //Reverse(ans);
            Console.WriteLine(Reverse(ans));
        }

        public static void ToDec(int n, int b)
        {
            string s = "";
            s = n.ToString();
            int num;
            int ans = 0;
            for(int i = 0; i < s.Length; i++)
            {
                if (s[i] == '1')
                {
                    num = (int)(s[i] - 48);
                    ans += num * (int)Math.Pow(b, s.Length - 1 - i);
                }
            }
            Console.WriteLine(ans);
        }
    }
}