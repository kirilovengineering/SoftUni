using System;

namespace PetShop_02102021
{
    class Program
    {
        static void Main(string[] args)
        {
      
            int NumberОfFoodDogs = int.Parse(Console.ReadLine());
            int NumberОfFoodCats = int.Parse(Console.ReadLine());

            const double PriceFoodDogs = 2.5;
            const double PriceFoodCats = 4.0;

            double FinalAmount = NumberОfFoodDogs * PriceFoodDogs + NumberОfFoodCats * PriceFoodCats;

            Console.WriteLine($"{FinalAmount} lv.");

        }
    }
}