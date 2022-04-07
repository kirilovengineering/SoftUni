﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.SoftUniBarIncome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Tuple<string, string, decimal>> customers = new List<Tuple<string, string, decimal>>();

            string pattern = @"%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>\d+\.?\d+)\$";

            string input;
            while ((input = Console.ReadLine()) != "end of shift")
            {

                Match match = Regex.Match(input, pattern);
                if (!match.Success)
                {
                    continue;
                }

                string name = match.Groups["customer"].Value;
                string product = match.Groups["product"].Value;
                int count = int.Parse(match.Groups["count"].Value);
                decimal price = decimal.Parse(match.Groups["price"].Value);

                customers.Add(new Tuple<string, string, decimal>(name, product, count * price));
            }

            foreach (Tuple<string, string, decimal> customer in customers)
            {
                Console.WriteLine($"{customer.Item1}: {customer.Item2} - {customer.Item3:F2}");
            }
            Console.WriteLine($"Total income: {customers.Sum(x => x.Item3):F2}");
        }
    }
}
