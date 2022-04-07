using System;

namespace _02.CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int n = 0;
            int totalSum = 0;

            if (input[0].Length >= input[1].Length)
            {
                n = input[1].Length;
                for (int i = input[1].Length; i < input[0].Length; i++)
                {
                    string str0 = input[0];
                    totalSum += (int)str0[i];
                }
            }
            else
            {
                n = input[0].Length;
                for (int i = input[0].Length; i < input[1].Length; i++)
                {
                    string str1 = input[1];
                    totalSum += (int)str1[i];
                }
            }

            for (int i = 0; i <= n - 1; i++)
            {
                string str0 = input[0];
                string str1 = input[1];

                int tempMultiply = (int)str0[i] * (int)str1[i];
                totalSum += tempMultiply;

            }

            Console.WriteLine(totalSum);
        }
    }
}
