using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            string steps = string.Empty;
            int countSteps = 0;
            int sumSteps = 0;

            while (steps != "Going home")
            {
                steps = Console.ReadLine();
                if (steps != "Going home")
                {
                    countSteps = int.Parse(steps);
                    sumSteps += countSteps;
                }

                if (sumSteps >= 10000)
                {
                    Console.WriteLine($"Goal reached! Good job!");
                    Console.WriteLine($"{(sumSteps - 10000)} steps over the goal!");
                    break;
                }

                if (steps == "Going home")
                {
                    steps = Console.ReadLine();
                    countSteps = int.Parse(steps);
                    sumSteps += countSteps;
                    if (sumSteps >= 10000)
                    {
                        Console.WriteLine($"Goal reached! Good job!");
                        Console.WriteLine($"{(sumSteps - 10000)} steps over the goal!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{(10000 - sumSteps)} more steps to reach goal.");
                        break;
                    }
                }
            }
        }
    }
}
