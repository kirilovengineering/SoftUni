using System;

namespace _1Task_CSharp_Exam14112021
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double nNights = int.Parse(Console.ReadLine());
            double nCardsT = int.Parse(Console.ReadLine());
            double nTicketM = int.Parse(Console.ReadLine());

            double sumNights = nNights * 20;
            double sumCrsdsT = nCardsT * 1.60;
            double sumTicketM = nTicketM * 6;

            double sum = sumNights + sumCrsdsT + sumTicketM;
            sum *= n;
            sum = sum + (sum * 0.25);

            Console.WriteLine($"{sum:F2}");

        }
    }
}
