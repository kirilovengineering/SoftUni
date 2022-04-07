using System;

namespace VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumberPages = int.Parse(Console.ReadLine());
            int PagesPerHour = int.Parse(Console.ReadLine());
            int NumberDays = int.Parse(Console.ReadLine());

            int SumTime = NumberPages / PagesPerHour;
            int NeededHours = SumTime / NumberDays;

            Console.WriteLine(NeededHours);
        }
    }
}