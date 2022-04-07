using System;

namespace Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameActor = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int numberEvaluate = int.Parse(Console.ReadLine());
            double winnings = points;
            double y = 0;
            for (int i = 1; i <= numberEvaluate; i++)
            {
                string nameEvaluate = Console.ReadLine();
                double pointsEvaluate = double.Parse(Console.ReadLine());
                winnings = winnings + (nameEvaluate.Length * pointsEvaluate) / 2;
                if (winnings > 1250.5)
                {
                    y = winnings;
                    Console.WriteLine($"Congratulations, {nameActor} got a nominee for leading role with {y:F1}!");
                    break;
                }
            }
            if (winnings < 1250.5)
            {
                Console.WriteLine($"Sorry, {nameActor} you need {(1250.5 - winnings):F1} more!");
            }
        }
    }
}
