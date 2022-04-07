using System;
using System.Linq;

namespace _02.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read single string
            string word = Console.ReadLine();
            //TODO Creat method which returns vowels count

            //Print wovels count

            int vowelsCount  = GetWavelsCount(word);
            Console.WriteLine(vowelsCount);
        }

        static int GetWavelsCount(string word)
        {
            char[] vovels = new char[] { 'a', 'e', 'i', 'o', 'u' };

            int vowelsCount = 0;

            foreach (char ch in word.ToLower())
            {
                if (vovels.Contains((ch)))
                {
                    vowelsCount++;
                }
            }

            return vowelsCount;
        }
    }
}
