using System;

namespace SuppliesForSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PricePackPencil = 5.8;
            const double PricePackMarker = 7.2;
            const double PriceBlackBoardCleaningAgentPerLiter = 1.2;

            double NumberPackPencil = double.Parse(Console.ReadLine());
            double NumberPackMarker = double.Parse(Console.ReadLine());
            double NumberBlackBoardCleaningAgentPerLiter = double.Parse(Console.ReadLine());
            double Dicount = double.Parse(Console.ReadLine());

            double PercentDiscount = Dicount / 100;

            double SumWithoutDiscount = (PricePackPencil * NumberPackPencil) + (PricePackMarker * NumberPackMarker) + (PriceBlackBoardCleaningAgentPerLiter * NumberBlackBoardCleaningAgentPerLiter);
            double SumWithDiscount = SumWithoutDiscount - (SumWithoutDiscount * PercentDiscount);
            
            Console.WriteLine(SumWithDiscount);
        }
    }
}