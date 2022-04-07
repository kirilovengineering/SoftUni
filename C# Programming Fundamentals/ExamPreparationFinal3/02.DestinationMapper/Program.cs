using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02.DestinationMapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"(=|\/)[A-Z][a-zA-Z]{2,}(\1)");
            MatchCollection matches = regex.Matches(input);

            List<string> places = new List<string>();
            int length = 0;

            foreach (Match match in matches)
            {

                string word = match.Value;
                word = word.Trim(new Char[] { '=', '/' });
                places.Add(word);
                length += word.Length;
            }

            Console.WriteLine($"Destinations: {string.Join(", ", places)}");
            Console.WriteLine($"Travel Points: {length}");
            

        }
    }
}
