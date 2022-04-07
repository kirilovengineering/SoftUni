using System;

namespace _5.PrintPartОfТheASCIITable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int currentIndex = start; currentIndex <= end; currentIndex++)
            {
                char currentChar = (char)currentIndex;
                Console.Write($"{currentChar} ");
            }
        }
    }
}
