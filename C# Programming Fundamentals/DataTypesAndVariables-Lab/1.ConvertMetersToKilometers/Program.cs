using System;


namespace _1.ConvertMetersToKilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            decimal kilometeres = meters / 1000.0M;

            //Console.WriteLine($"{Math.Round(kilometeres, 2, MidpointRounding.AwayFromZero):F2}");
 

        }
    }
}
