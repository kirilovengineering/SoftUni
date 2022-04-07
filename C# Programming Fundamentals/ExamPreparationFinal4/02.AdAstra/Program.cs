using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.AdAstra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"(\||#)([A-Z a-z]+)(\1)([0-9]{2}\/[0-9]{2}\/[0-9]{2})(\1)([0-9]+)(\1)");

            MatchCollection matches = regex.Matches(input);
            List<string> dataForFood = new List<string>();
            int calories = 0;

            foreach (Match match in matches)
            {
                string tempData = match.Value;
                tempData = tempData.Trim(new Char[] { '|', '#' });
                dataForFood.Add(tempData);
            }

            int numberOfMatches = dataForFood.Count;

            for (int i = 0; i < numberOfMatches; i++)
            {
                string temp = dataForFood[i];


                char[] separators = new char[] { '|', '#' };
                string[] foodDataCalories = temp
                         .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                         .ToArray();

                calories = calories + int.Parse(foodDataCalories[2]);

            }
            int days = calories / 2000;
            Console.WriteLine($"You have food to last you for: {days} days!");
            
            for (int i = 0; i < numberOfMatches; i++)
            {
                string temp = dataForFood[i];


                char[] separators = new char[] { '|', '#' };
                string[] foodDataCalories = temp
                         .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                         .ToArray();

                Console.WriteLine($"Item: {foodDataCalories[0]}, Best before: {foodDataCalories[1]}, Nutrition: {foodDataCalories[2]}");
            }

        }
    }
}
