using System;

namespace _3Task_CSharp_Exam14112021
{
    class Program
    {
        static void Main(string[] args)
        {
            int nuberPeople = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double excursion = 0.0;
            double discount = 0.0;
            double markup = 0.0;

            if (nuberPeople <= 5)
            {
                if (season == "spring")
                {
                    excursion = 50.00;
                }
                else if (season == "summer")
                {
                    excursion = 48.50;
                    discount = 48.50 * 0.15;
                    excursion -= discount;
                }
                else if (season == "autumn")
                {
                    excursion = 60.00;
                }
                else if (season == "winter")
                {
                    excursion = 86.00;
                    markup = 86.00 * 0.08;
                    excursion += markup;
                }
            }
            else if (nuberPeople > 5)
            {
                if (season == "spring")
                {
                    excursion = 48.00;
                }
                else if (season == "summer")
                {
                    excursion = 45.00;
                    discount = 45.00 * 0.15;
                    excursion -= discount;
                }
                else if (season == "autumn")
                {
                    excursion = 49.50;
                }
                else if (season == "winter")
                {
                    excursion = 85.00;
                    markup = 85.00 * 0.08;
                    excursion += markup;
                }
            }
            Console.WriteLine($"{nuberPeople * excursion:F2} leva.");
        }
    }
}
