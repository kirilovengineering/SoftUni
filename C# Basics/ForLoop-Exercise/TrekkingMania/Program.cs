using System;

namespace TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleMusala = 0, peopleMontblan = 0, peopleKilimandjaro = 0, peopleK2 = 0, peopleEvrest = 0;
            int groupsCount = int.Parse(Console.ReadLine());
            int totalPeopleCount = 0;

            for (int i = 0; i < groupsCount; i++)
            {
                int peopleCount = int.Parse(Console.ReadLine());
                totalPeopleCount += peopleCount;
                if (peopleCount <= 5)
                {
                    peopleMusala += peopleCount;
                }
                else if (peopleCount <= 12)
                {
                    peopleMontblan += peopleCount;
                }
                else if (peopleCount <= 25)
                {
                    peopleKilimandjaro += peopleCount;
                }
                else if (peopleCount <= 40)
                {
                    peopleK2 += peopleCount;
                }
                else
                {
                    peopleEvrest += peopleCount;
                }
            }
            double p1Percentage, p2Percentage, p3Percentage, p4Percentage, p5Percentage;
            p1Percentage = (double)peopleMusala / totalPeopleCount * 100;
            p2Percentage = (double)peopleMontblan / totalPeopleCount * 100;
            p3Percentage = (double)peopleKilimandjaro / totalPeopleCount * 100;
            p4Percentage = (double)peopleK2 / totalPeopleCount * 100;
            p5Percentage = (double)peopleEvrest / totalPeopleCount * 100;

            Console.WriteLine($"{p1Percentage:F2}%");
            Console.WriteLine($"{p2Percentage:F2}%");
            Console.WriteLine($"{p3Percentage:F2}%");
            Console.WriteLine($"{p4Percentage:F2}%");
            Console.WriteLine($"{p5Percentage:F2}%");
        }
    }
}
