using System;

namespace TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            int presentationCount = 0;
            string presentationName = Console.ReadLine();

            while (presentationName != "Finish")
            {
                double currentSum = 0;
                for (int i = 0; i < n; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    currentSum += grade;
                }
                double averageGrade = currentSum / n;
                Console.WriteLine($"{presentationName} - {averageGrade:F2}.");
                sum += averageGrade;
                presentationCount++;
                presentationName = Console.ReadLine();
            }
            Console.WriteLine($"Student's final assessment is {sum / presentationCount:F2}.");

        }
    }
}
