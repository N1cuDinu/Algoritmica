using System;

namespace Factorial // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = int.Parse(Console.ReadLine());
            int factor = factorial(i);
            Console.WriteLine(factor);
        }

        static int factorial(int nr)
        {
            int rezultat = 1;
            for(int i=1; i <=nr; i++)
            {
                rezultat = rezultat * i;
            }
            return rezultat;
        }
    }
}