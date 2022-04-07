using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            int grades = 1;
            double currentGrade = 0;
            double gradesSum = 0;
            bool graduated = true;
            int failCounter = 0;

            while (grades <= 12)
            {
                currentGrade = double.Parse(Console.ReadLine());
                if (currentGrade < 4)
                {
                    failCounter++;
                    if (failCounter > 1)
                    {
                        Console.WriteLine($"{studentName} has been excluded at {grades} grade");
                        graduated = false;
                        break;
                    }

                    continue;
                }

                gradesSum += currentGrade;
                grades++;
            }

            if (graduated)
            {
                Console.WriteLine($"{studentName} graduated. Average grade: {(gradesSum / 12):F2}");
            }
        }
    }
}
