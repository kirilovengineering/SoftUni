using System;
using System.Collections.Generic;

namespace _05.CountSymbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char[] charText = new char[text.Length];
            SortedDictionary<char, int> sortedText = new SortedDictionary<char, int>();


            for (int i = 0; i < text.Length; i++)
            {
                charText[i] = text[i];
                if (!sortedText.ContainsKey(charText[i]))
                {
                    sortedText.Add(charText[i], 1);
                }
                else 
                {                 
                    sortedText[charText[i]] = sortedText[charText[i]] + 1;
                }

            };

            foreach (KeyValuePair<char, int> item in sortedText)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }

        }
    }
}
