using System;
using System.Linq;

namespace _8.MagicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();

            int magicSum = int.Parse(Console.ReadLine());

            for (int multiplierOneIndex = 0; multiplierOneIndex < numbers.Length - 1; multiplierOneIndex++)
            {
                for (int multiplierTwoIndex = multiplierOneIndex + 1; multiplierTwoIndex <= numbers.Length - 1; multiplierTwoIndex++)
                {
                    if (numbers[multiplierOneIndex] + numbers[multiplierTwoIndex] == magicSum)
                    {
                        Console.WriteLine($"{numbers[multiplierOneIndex]} {numbers[multiplierTwoIndex]}");
                    }
                }
            }
        }
    }
}
