using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberPoorEvaluation = int.Parse(Console.ReadLine());

            double averageScore = 0;
            double numberOfProblems = 0;
            string lastProblem = string.Empty;
            string problem = string.Empty;
            int score = 0;
            double sumScore = 0;
            int poor = 0;

            while (problem != "Enough")
            {
                problem = Console.ReadLine();
                if (problem != "Enough")
                {
                    score = int.Parse(Console.ReadLine());
                    numberOfProblems++;
                    sumScore += score;
                    averageScore = sumScore / numberOfProblems;
                    lastProblem = problem;
                }

                if (score <= 4)
                {
                    poor++;
                };

                if (poor >= numberPoorEvaluation)
                {
                    Console.WriteLine($"You need a break, {numberPoorEvaluation} poor grades.");
                    break;
                };

                if (problem == "Enough")
                {
                    Console.WriteLine($"Average score: {averageScore:F2}");
                    Console.WriteLine($"Number of problems: {numberOfProblems}");
                    Console.WriteLine($"Last problem: {lastProblem}");
                }
            }
        }
    }
}
