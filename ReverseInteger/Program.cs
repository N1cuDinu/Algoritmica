using System;
namespace ReverseInteger // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numarul pe care doriti sa il inversati");
            int x = int.Parse(Console.ReadLine());
            int raspuns = ReverseInt(x);
            Console.WriteLine(raspuns);
        }

        static int ReverseInt(int number)
        {
            int reverse=0;
            while (number != 0)
            {
                try {
                    checked{ 
                    reverse = reverse * 10 + number % 10;
                    number = number / 10;
                    }
                }
                catch (System.OverflowException)
                {
                    return 0;
                }
            }
            return reverse;
        }
    }
}