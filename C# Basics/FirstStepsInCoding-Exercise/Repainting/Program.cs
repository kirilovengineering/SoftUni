using System;

namespace Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PriceProtectiveNylonPerMeter = 1.50;
            const double PricePaintPerLiter = 14.50;
            const double PricePaintThinnerPerLiter = 5.00;

            const double AddPaintInPercent = 1.10;
            const double AddNylon = 2;
            const double SumBag = 0.40;

            const double SalaryPerHourInPercent = 0.30;

            int Nylon = int.Parse(Console.ReadLine());
            int Paint = int.Parse(Console.ReadLine());
            int Thinner = int.Parse(Console.ReadLine());
            int Hour = int.Parse(Console.ReadLine());

            double SumNylon = (Nylon + AddNylon) * PriceProtectiveNylonPerMeter;
            double SumPaint = (Paint * AddPaintInPercent) * PricePaintPerLiter;
            double SumThinner = Thinner * PricePaintThinnerPerLiter;

            double TotalMaterials = (SumNylon + SumPaint + SumThinner + SumBag);
            double TotalWork = ((SumNylon + SumPaint + SumThinner + SumBag) * Hour) * SalaryPerHourInPercent;

            double Total = TotalMaterials + TotalWork;
            Console.WriteLine(Total);
        }
    }
}