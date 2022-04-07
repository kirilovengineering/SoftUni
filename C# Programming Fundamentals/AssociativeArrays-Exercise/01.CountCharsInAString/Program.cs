using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01.CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            inputString = Regex.Replace(inputString, @" ", "");


            List<string> inputList = new List<string>();
            
            foreach (var item in inputString)
            {
                inputList.Add(item.ToString());
            }

            Dictionary<string, int> CountedDictionary = new Dictionary<string, int>();

            foreach (var item in inputList)
            {
                if (CountedDictionary.ContainsKey(item))
                {
                    CountedDictionary[item] = CountedDictionary[item] + 1;
                }
                else
                {
                    CountedDictionary.Add(item, 1);
                }
            }

            foreach (var item in CountedDictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
