using System;

namespace _01.GuineaPig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double food = double.Parse(Console.ReadLine());
            double hay = double.Parse(Console.ReadLine());
            double cover = double.Parse(Console.ReadLine());
            double kgs = double.Parse(Console.ReadLine());

            double neeededFood = .300 * 30;
            double neeededHay = 0;// (food - (neeededFood / 2)) * .05;

            double tempFood = food;
            double tempHay = hay;
            for (int i = 1; i <= 15; i++)
            {
                tempFood -= .600;
                neeededHay = tempFood * .05;
                tempHay = tempHay - neeededHay;
            }
           
            double neeededCover = 10 * (kgs / 3);

            if (food > neeededFood && hay > neeededHay && cover > neeededCover)
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {food - neeededFood:F2}, Hay: {tempHay:F2}, Cover: {cover - neeededCover:F2}.");
            }
            else
            {
                Console.WriteLine($"Merry must go to the pet store!");
            }
        }
    }
}
