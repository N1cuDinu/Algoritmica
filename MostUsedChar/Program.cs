using System;

namespace MostUsedChar // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            char caracter = countChar(s);
            Console.WriteLine(caracter);
        }

        static char countChar(string s)
        {
            int []charCounter = new int[256];
            for(int i=0; i < s.Length; i++)
            {
                charCounter[s[i]]++;
            }
            int counter =0;
            char caract = ' ';
            for(int i=0; i < s.Length; i++)
            {
                if (counter < charCounter[s[i]]) { 
                    counter = charCounter[s[i]];
                    caract = s[i];
                }
            }
            return caract;
        }
    }
}