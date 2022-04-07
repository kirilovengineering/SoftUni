using System;
using System.Text.RegularExpressions;

namespace _03.MatchDates
{
    internal class Program
    {
        public static object MatcchCollection { get; private set; }

        static void Main(string[] args)
        {
            string regex = @"(?<day>\d{2})(\/|-|.)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})";

            string datesString = Console.ReadLine();

            MatchCollection matchedString = Regex.Matches(datesString, regex);

            foreach (Match item in matchedString)
            {
                var day = item.Groups["day"].Value;
                var month = item.Groups["month"].Value;
                var year = item.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
