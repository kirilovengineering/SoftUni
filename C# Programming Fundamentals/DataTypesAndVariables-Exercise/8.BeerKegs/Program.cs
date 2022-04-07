using System;

namespace _8.BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfModels = int.Parse(Console.ReadLine());
            string currBigName = string.Empty;
            double currBigVol = 0;
            for (int i = 0; i < numberOfModels; i++)
            {
                string name = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double volume = Math.PI * radius * radius * height;
                if (volume > currBigVol)
                {
                    currBigName = name;
                    currBigVol = volume;
                }
            }
            Console.WriteLine(currBigName);
        }
    }
}
