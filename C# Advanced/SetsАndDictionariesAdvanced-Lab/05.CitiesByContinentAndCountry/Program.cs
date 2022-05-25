using System;
using System.Collections.Generic;

namespace _05.CitiesByContinentAndCountry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cities = new Dictionary<string, Dictionary<string, List<string>>>();
            int citiesCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < citiesCount; i++)
            {
                string[] tokens = Console.ReadLine().Split(" ");
                string continent = tokens[0];
                string country = tokens[1];
                string city = tokens[2];
                AddCity(cities, continent, country, city);

            }
            PrintCitiesByContinentAndCountry(cities);

        }

        private static void AddCity(Dictionary<string, Dictionary<string, List<string>>> cities, string continent, string country, string city)
        {
            // Add the continent if missing
            if (!cities.ContainsKey(continent))
                cities.Add(continent, new Dictionary<string, List<string>>());
            Dictionary<string, List<string>> countries = cities[continent];
            // Add the country in the continent if missing
            if (!countries.ContainsKey(country))
                countries.Add(country, new List<string>());
            //Add the sity in existing continent --> country
            countries[country].Add(city);

        }

        private static void PrintCitiesByContinentAndCountry(Dictionary<string, Dictionary<string, List<string>>> cities)
        {
            foreach (var continentName in cities.Keys)
            {
                var countries = cities[continentName];
                Console.WriteLine(continentName + ":");
                foreach (var countryName in countries.Keys)
                {
                    Console.Write("  " + countryName + " -> ");
                    List<string> citiesInCountry = countries[countryName];
                    Console.WriteLine(string.Join(", ", citiesInCountry));
                }
            }
        }

        // With kvp!! 
        //static void PrintCitiesByContinentAndCountry(
        //Dictionary<string, Dictionary<string, List<string>>> cities)
        //{
        //    foreach (var (continentName, countries) in cities)
        //    {
        //        Console.WriteLine(continentName + ":");
        //        foreach (var (countryName, citiesInCountry) in countries)
        //        {
        //            Console.WriteLine("  " + countryName + " -> " +
        //                string.Join(", ", citiesInCountry));
        //        }
        //    }
        //}

    }
}
