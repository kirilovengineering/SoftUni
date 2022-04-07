using System;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double secondsPerOneMeter = double.Parse(Console.ReadLine());

            double delayPerDistance = (Math.Floor(distanceInMeters / 15)) * 12.5;
            double totalTime = distanceInMeters * secondsPerOneMeter + delayPerDistance;


            if (recordInSeconds <= totalTime)
            {
                Console.WriteLine($"No, he failed! He was {(totalTime - recordInSeconds):F2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {(totalTime):F2} seconds.");
            }
        }
    }
}
