using System;

namespace _1.Ages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Age = int.Parse(Console.ReadLine());

            switch (Age)
            {
                case int n when (Age >= 0 && Age <= 2):
                    Console.WriteLine($"baby");
                    break;
                case int n when (Age >= 3 && Age <= 13):
                    Console.WriteLine($"child");
                    break;
                case int n when (Age >= 13 && Age <= 19):
                    Console.WriteLine($"teenager");
                    break;
                case int n when (Age >= 20 && Age <= 65):
                    Console.WriteLine($"adult");
                    break;
                case int n when (Age >= 65):
                    Console.WriteLine($"elder");
                    break;
                default:
                    break;
            }
        }
    }
}