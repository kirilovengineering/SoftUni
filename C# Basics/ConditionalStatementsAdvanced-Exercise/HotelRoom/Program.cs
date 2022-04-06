using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double studioNight = 0;
            double apartmentNight = 0;
            double resultStudio = 0;
            double resultApartment = 0;

            if (month == "May" || month == "October")
            {
                studioNight = 50;
                apartmentNight = 65;
            }
            else if (month == "June" || month == "September")
            {
                studioNight = 75.20;
                apartmentNight = 68.70;
            }
            else if (month == "July" || month == "August")
            {
                studioNight = 76;
                apartmentNight = 77;
            }
            resultStudio = nights * studioNight;
            resultApartment = nights * apartmentNight;
            if ((month == "May" || month == "October") && nights > 7 && nights <= 13)
            {
                resultStudio = resultStudio * 0.95;
            }
            else if ((month == "May" || month == "October") && nights > 14)
            {
                resultStudio = resultStudio * 0.7;
            }
            else if ((month == "June" || month == "September") && nights > 14)
            {
                resultStudio = resultStudio * 0.8;
            }
            if (nights > 14)
            {
                resultApartment = resultApartment * 0.9;
            }

            Console.WriteLine($"Apartment: {resultApartment:F2} lv.");
            Console.WriteLine($"Studio: {resultStudio:F2} lv.");
        }
    }
}
