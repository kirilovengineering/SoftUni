using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double cost = 0;
            string country = "";
            string sleepin = "";

            if (budget <= 100)
            {
                country = "Bulgaria";
                switch (season)
                {
                    case "summer":
                        cost = budget * 0.3;
                        sleepin = "Camp";
                        break;
                    case "winter":
                        cost = budget * 0.7;
                        sleepin = "Hotel";
                        break;
                }
            }
            if (budget > 100 && budget <= 1000)
            {
                country = "Balkans";
                switch (season)
                {
                    case "summer":
                        cost = budget * 0.4;
                        sleepin = "Camp";
                        break;
                    case "winter":
                        cost = budget * 0.8;
                        sleepin = "Hotel";
                        break;
                }
            }
            if (budget > 1000)
            {
                country = "Europe";
                cost = budget * 0.9;
                sleepin = "Hotel";
            }

            Console.WriteLine($"Somewhere in {country}");
            Console.WriteLine($"{sleepin} - {cost:F2}");
        }
    }
}
