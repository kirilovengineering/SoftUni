using System;
using System.Linq;

namespace _02.SumNumbers
{
    internal class Program

    {
        // Вариант 1
        static int Parse1(string str)
        {
            int result = int.Parse(str);
            return result;
        }
        // Вариант 2
        static int Parse2(string str) => int.Parse(str);

        // няма значение кой вариант ще използваме
        static void Main(string[] args)
        {
            static int Parse(string str) => int.Parse(str);

            string input = Console.ReadLine();
            int[] nums = input.Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(Parse)
                .ToArray();

            Console.WriteLine(nums.Count());
            Console.WriteLine(nums.Sum());

        }
    }
}
