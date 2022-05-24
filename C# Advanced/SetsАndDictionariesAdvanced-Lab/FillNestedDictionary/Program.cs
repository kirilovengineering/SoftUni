using System;
using System.Collections.Generic;

namespace FillNestedDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var population = new Dictionary<string, Dictionary<string, int>> {
    {"BG",
        new Dictionary<string, int> {
            { "Sofia", 1_211_000 },
            { "Plovdiv", 338_000 },
            { "Varna", 335_000 },
        }
    },
    {"UK",
        new Dictionary<string, int> {
            { "London", 8_674_000 },
            { "Manchester", 2_550_000 },
        }
    }, …
};

        }
    }
}
