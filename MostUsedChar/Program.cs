using System;

namespace MostUsedChar // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            //char caracter = countChar(s);
            //Console.WriteLine(caracter);

            countCharDictionar(s);
            Console.WriteLine(s) ;
        }

        //static char countChar(string s)
        //{
        //    //dictionar
        //    int []charCounter = new int[256];
        //    for(int i=0; i < s.Length; i++)
        //    {
        //        charCounter[s[i]]++;
        //    }
        //    int counter =0;
        //    char caract = ' ';
        //    for(int i=0; i < s.Length; i++)
        //    {
        //        if (counter < charCounter[s[i]]) { 
        //            counter = charCounter[s[i]];
        //            caract = s[i];
        //        }
        //    }
        //    return caract;
        //}

        public static char[] countCharDictionar(string word)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();

            foreach(char c in word)
            {
                if (dic.ContainsKey(c))
                    dic[c]++;
                else dic.Add(c, 1);
            }
            int maxChar = dic.Values.Max();
            return dic.Where(b => b.Value == maxChar).Select(b => b.Key).ToArray();
        }
    }
}