using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var regex = @"\+359( |-)2\1\d{3}\1\d{4}\b";

            var phone = Console.ReadLine();

            //MatchCollection
            var phoneMatches = Regex.Matches(phone, regex);

            var mattchedPhones = phoneMatches
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();

            Console.WriteLine(String.Join(", ", mattchedPhones));
        }
    }
}