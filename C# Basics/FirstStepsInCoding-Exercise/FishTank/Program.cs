using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            double fishTankLenght = int.Parse(Console.ReadLine());
            double fishTankWidth = int.Parse(Console.ReadLine());
            double fishTankHeigt = int.Parse(Console.ReadLine());
            double sandPlantsHeaterPump = double.Parse(Console.ReadLine());

            double sandPlantsHeaterPumpInPercent = sandPlantsHeaterPump / 100;
           

            double volumeInLiters = (fishTankLenght * fishTankWidth * fishTankHeigt) / 1000;
            double neededLiters = volumeInLiters * (1 - sandPlantsHeaterPumpInPercent);

            Console.WriteLine(neededLiters);
        }
    }
}