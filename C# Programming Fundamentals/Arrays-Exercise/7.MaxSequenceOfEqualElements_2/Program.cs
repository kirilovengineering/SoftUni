using System;
using System.Linq;

namespace _7.MaxSequenceOfEqualElements_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arreyOfNumbers = Console.ReadLine()
                            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();

            int cnt = 1;
            int dublicate = 0;
            int index = arreyOfNumbers[0];
            int best = 0;

            for (int i = 1; i < arreyOfNumbers.Length; i++)
            {
                if (index == arreyOfNumbers[i])
                {
                    cnt++;
                }
                else
                {
                    index = arreyOfNumbers[i];
                    cnt = 1;
                }
                if (cnt > best)
                {
                    best = cnt;
                    dublicate = arreyOfNumbers[i];
                }
            }
            for (int i = 0; i < best; i++)
            {
                Console.Write($"{dublicate} ");
            }
        }
    }
}
