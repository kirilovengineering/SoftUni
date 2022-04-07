using System;

namespace BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int AnnualTax = int.Parse(Console.ReadLine());

            double Shoes = AnnualTax - (AnnualTax * 0.40);
            double Jersey = Shoes - (Shoes * 0.2);
            double Ball = Jersey / 4;
            double Accessories = Ball / 5;

            double Total = AnnualTax + Shoes + Jersey + Ball + Accessories;

            Console.WriteLine(Total);
        }
    }
}