using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberNVideocards = int.Parse(Console.ReadLine());
            int numberMProcessors = int.Parse(Console.ReadLine());
            int numberPMemories = int.Parse(Console.ReadLine());

            double priceVideocards = 250;

            double sumV = numberNVideocards * priceVideocards;
            double sumP = numberMProcessors * (sumV * 0.35);
            double sumM = numberPMemories * (sumV * 0.10);

            double sum = ( sumV + sumP + sumM);

            if (numberNVideocards >= numberMProcessors)
            {
                sum = sum * 0.85;
            }

            if (budget >= sum)
            {
                Console.WriteLine($"You have {(budget - sum):F2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(sum - budget):F2} leva more!");
            }
        }
    }
}