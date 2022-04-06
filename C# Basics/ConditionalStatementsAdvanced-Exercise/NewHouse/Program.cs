using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowersType = Console.ReadLine();
            int flowersCounts = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double total = 0;

            switch (flowersType)
            {
                case "Roses":
                    if (flowersCounts > 80)
                    {
                        total = flowersCounts * 5 * 0.9;
                    }
                    else
                    {
                        total = flowersCounts * 5;
                    }
                    break;
                case "Dahlias":
                    if (flowersCounts > 90)
                    {
                        total = flowersCounts * 3.8 * 0.85;
                    }
                    else
                    {
                        total = flowersCounts * 3.8;
                    }
                    break;
                case "Tulips":
                    if (flowersCounts > 80)
                    {
                        total = flowersCounts * 2.8 * 0.85;
                    }
                    else
                    {
                        total = flowersCounts * 2.8;
                    }
                    break;
                case "Narcissus":
                    if (flowersCounts < 120)
                    {
                        total = flowersCounts * 3 * 1.15;
                    }
                    else
                    {
                        total = flowersCounts * 3;
                    }
                    break;
                case "Gladiolus":
                    if (flowersCounts < 80)
                    {
                        total = flowersCounts * 2.5 * 1.2;
                    }
                    else
                    {
                        total = flowersCounts * 2.5;
                    }
                    break;
            }
            if (budget >= total)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowersCounts} {flowersType} and {budget - total:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {total - budget:F2} leva more.");
            }
        }
    }
}
