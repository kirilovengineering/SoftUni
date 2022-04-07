using System;

namespace _7.WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int waterTank = 255;
            int waterLiters = 0;


            for (int i = 1; i <= input; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                waterLiters += liters;
                if (waterLiters > waterTank)
                {
                    Console.WriteLine("Insufficient capacity!");
                    waterLiters -= liters;
                }
            }
            Console.WriteLine(waterLiters);

        }
    }
}
