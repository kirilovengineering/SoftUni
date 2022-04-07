using System;

namespace YardGreening_02102021
{
    class Program
    {
        static void Main(string[] args)
        {
            double SquareMeters = double.Parse(Console.ReadLine());
            
            const double PricePerSqareMeterWithDDS = 7.61;
            const double Discont = 0.18;

            double FinalAmount = SquareMeters * PricePerSqareMeterWithDDS;
            double FinalDicount = FinalAmount * Discont ;
            double FinalAmountWithDiscount = FinalAmount - FinalDicount;

            Console.WriteLine($"The final price is: {FinalAmountWithDiscount} lv.");
            Console.WriteLine($"The discount is: {FinalDicount} lv.");
        }
    }
}