using System;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalCount = 0, standardCount = 0, kidsCount = 0, studentsCount = 0;
            string movieName = Console.ReadLine();
            while (movieName != "Finish")
            {
                int places = int.Parse(Console.ReadLine());
                int currentTickets = 0;
                for (int i = 0; i < places; i++)
                {
                    string ticketType = Console.ReadLine();
                    if (ticketType == "End")
                    {
                        break;
                    }
                    switch (ticketType)
                    {
                        case "student":
                            studentsCount++;
                            break;
                        case "standard":
                            standardCount++;
                            break;
                        case "kid":
                            kidsCount++;
                            break;                 
                    }
                    currentTickets++;
                }
                totalCount += currentTickets;
                double percentage = (double)currentTickets / places * 100;
                Console.WriteLine($"{movieName} - {percentage:F2}% full.");             
                movieName = Console.ReadLine();
            }
            double studentsPercenatage = (double)studentsCount / totalCount * 100;
            double kidsPercentage = (double)kidsCount / totalCount * 100;
            double standardPercenatage = (double)standardCount / totalCount * 100;

            Console.WriteLine($"Total tickets: {totalCount}");
            Console.WriteLine($"{studentsPercenatage:F2}% student tickets.");
            Console.WriteLine($"{standardPercenatage:F2}% standard tickets.");
            Console.WriteLine($"{kidsPercentage:F2}% kids tickets.");
        }
    }
}
