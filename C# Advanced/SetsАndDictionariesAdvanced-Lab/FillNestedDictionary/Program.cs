using System;
using System.Collections.Generic;

namespace FillNestedDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var population = new Dictionary<string, Dictionary<string, int>>
            {
                {"BG",
                     new Dictionary<string, int>
                    {
                        { "Sofia", 1_211_000 }, // подчертавките служат за разделяне визуално е по удоно, същата цифра си остава като такава
                        { "Plovdiv", 338_000 },
                        { "Varna", 335_000 },
                    }
                },
                {"UK",
                        new Dictionary<string, int>
                    {
                        { "London", 8_674_000 },
                        { "Manchester", 2_550_000 },
                    }
                }
            };

            //Nested Dictionaries: Printing
            foreach (var (countryName, towns) in population)
            {
                Console.WriteLine("Country: " + countryName);
                foreach (var (townName, townPop) in towns)
                    Console.WriteLine(
                       $"\tTown {townName} --> population {townPop}");
            }

            //Nested Dictionaries: Adding New Entry with method

            AddPopulation("China", "Shanghai", 24_300_000);
            AddPopulation("China", "Beijing", 18_800_000);
            AddPopulation("China", "Shenzhen", 12_700_000);
            AddPopulation("BG", "Stara Zagora", 250_000);

            void AddPopulation(string country, string town, int townPop)
            {
                if (!population.ContainsKey(country))
                    population[country] = new Dictionary<string, int>();
                population[country][town] = townPop;
            }

        }
    }
}
