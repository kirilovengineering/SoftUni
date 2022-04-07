using System;

namespace TennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournamentCount = int.Parse(Console.ReadLine());
            int startPoint = int.Parse(Console.ReadLine());
            string stage = string.Empty;         
            int points = 0;
            double average = 0;
            double percent = 0;
            int tournamentsWon = 0;

            points = startPoint;

            for (int i = 0; i < tournamentCount; i++)
            {
                stage = Console.ReadLine();

                if (stage == "F")
                {
                    points += 1200;
                }
                else if (stage == "W")
                {
                    points += 2000;
                    tournamentsWon++;
                }
                else if (stage == "SF")
                {
                    points += 720;
                }
            }
            average = (points - startPoint) / tournamentCount;
            percent = ((double)tournamentsWon / tournamentCount) * 100;

            Console.WriteLine($"Final points: {points}");
            Console.WriteLine($"Average points: {Math.Floor(average)}");
            Console.WriteLine($"{percent:f2}%");
        }
    }
}
