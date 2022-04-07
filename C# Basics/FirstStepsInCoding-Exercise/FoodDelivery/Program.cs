using System;

namespace FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PriceMenuChicken = 10.35;
            const double PriceMenuFish = 12.40;
            const double PriceMenuVegan = 8.15;

            const double DiscountForDessertFromTotal = 0.20;
            const double Delivery = 2.50;

            int NumberMenuChicken = int.Parse(Console.ReadLine());
            int NumberMenuFish = int.Parse(Console.ReadLine());
            int NumberMenuVegan = int.Parse(Console.ReadLine());

            double SumMenuChicken = NumberMenuChicken * PriceMenuChicken;
            double SumMenuFish = NumberMenuFish * PriceMenuFish;
            double SumMenuVegan = NumberMenuVegan * PriceMenuVegan;

            double TotalOrderMenu = SumMenuChicken + SumMenuFish + SumMenuVegan;
            double TotalDessert = TotalOrderMenu * DiscountForDessertFromTotal;

            double Total = TotalOrderMenu + TotalDessert + Delivery;
            Console.WriteLine(Total);
        }
    }
}