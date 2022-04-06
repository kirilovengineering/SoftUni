using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                double budget = double.Parse(Console.ReadLine());
                string season = Console.ReadLine();
                int fishersCounts = int.Parse(Console.ReadLine());

                double total = 0;
                double temp = 0;

                switch (season)
                {
                    case "Spring":
                        if (fishersCounts <= 6)
                        {
                            total = 3000 * 0.9;
                        }
                        else if (fishersCounts > 7 && fishersCounts <= 11)
                        {
                            total = 3000 * 0.85;
                        }
                        else if (fishersCounts > 12)
                        {
                            total = 3000 * 0.75;
                        }
                        temp = fishersCounts % 2;
                        if (temp == 0) { total = total * 0.95; };
                        break;

                    case "Summer":
                        if (fishersCounts <= 6)
                        {
                            total = 4200 * 0.9;
                        }
                        else if (fishersCounts > 7 && fishersCounts <= 11)
                        {
                            total = 4200 * 0.85;
                        }
                        else if (fishersCounts > 12)
                        {
                            total = 4200 * 0.75;
                        }
                        temp = fishersCounts % 2;
                        if (temp == 0) { total = total * 0.95; };
                        break;

                    case "Autumn":
                        if (fishersCounts <= 6)
                        {
                            total = 4200 * 0.9;
                        }
                        else if (fishersCounts > 7 && fishersCounts <= 11)
                        {
                            total = 4200 * 0.85;
                        }
                        else if (fishersCounts > 12)
                        {
                            total = 4200 * 0.75;
                        }
                        break;

                    case "Winter":
                        if (fishersCounts <= 6)
                        {
                            total = 2600 * 0.9;
                        }
                        else if (fishersCounts > 7 && fishersCounts <= 11)
                        {
                            total = 2600 * 0.85;
                        }
                        else if (fishersCounts > 12)
                        {
                            total = 2600 * 0.75;
                        }
                        temp = fishersCounts % 2;
                        if (temp == 0) { total = total * 0.95; };
                        break;
                }

                if (budget >= total)
                {
                    Console.WriteLine($"Yes! You have {budget - total:F2} leva left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! You need {total - budget:F2} leva.");
                }
            }
        }
    }
}
