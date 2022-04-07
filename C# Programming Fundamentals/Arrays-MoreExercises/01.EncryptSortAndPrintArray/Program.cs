using System;
using System.Linq;

namespace _01.EncryptSortAndPrintArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] arrayWords = new string[n];
            int[] arrayWordsCript = new int[n];
            int[] arraySorted = new int[n];
            string arrayWordsString = string.Empty;

            int sumWordsVowel = 0; 
            int sumWordsConsonant = 0;
            int sumWords = 0;


            for (int i = 0; i < n; i++)
            {
                
                arrayWords[i] = Console.ReadLine();

                arrayWordsString = arrayWords[i];
                for (int j = 0; j < arrayWordsString.Length; j++)
                {
                    char c = arrayWordsString[j];
                    bool isVowel = "aeiou".IndexOf(c.ToString(), StringComparison.InvariantCultureIgnoreCase) >= 0;
                    if (isVowel)
                    {
                        sumWordsVowel += ((int)arrayWordsString[j]) * arrayWordsString.Length;
                    }
                    else
                    {
                        sumWordsConsonant += ((int)arrayWordsString[j]) / arrayWordsString.Length;
                    }
                }
                sumWords = sumWordsVowel + sumWordsConsonant;
                arrayWordsCript[i] = sumWords;
                sumWordsVowel = 0;
                sumWordsConsonant = 0;
                sumWords = 0;
            }

            arraySorted = arrayWordsCript.OrderByDescending(c => c).ToArray();

            for (int i = arraySorted.Length - 1; i >= 0 ; i--)
            {
                Console.WriteLine(arraySorted[i]);
            }
        }
    }
}
