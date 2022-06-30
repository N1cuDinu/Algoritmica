using System;

namespace Palindrom1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = ReverseString(s1);
            bool palindrom = false;
            if (s1 == s2)
            {
                palindrom = true;
                Console.WriteLine("Este palindrom");
            }
            else
            {
                Console.WriteLine("Nu este palindrom");
            }
            

        }

        public static string ReverseString(string s)
        {
            char[] rev = s.ToCharArray();
            Array.Reverse(rev);
            return new string(rev);
        }

    }
}