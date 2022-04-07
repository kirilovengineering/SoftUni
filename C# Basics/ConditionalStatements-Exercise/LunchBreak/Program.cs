using System;

namespace LunchBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double episodeLength = double.Parse(Console.ReadLine());
            double breakLength = double.Parse(Console.ReadLine());
            double totalTime = episodeLength;
            totalTime += breakLength / 8;
            totalTime += breakLength / 4;

            if (breakLength >= totalTime)
            {
                double leftTime = Math.Ceiling(breakLength - totalTime);
                Console.WriteLine($"You have enough time to watch {name} and left with {leftTime} minutes free time.");
            }
            else
            {
                double leftTime = Math.Ceiling(totalTime - breakLength);
                Console.WriteLine($"You don't have enough time to watch {name}, you need {leftTime} more minutes.");
            }

        }
    }
}
