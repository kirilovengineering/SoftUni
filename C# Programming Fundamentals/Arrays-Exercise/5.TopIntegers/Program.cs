using System;
using System.Linq;

namespace _5.TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            //Worst case -> all intwgers will be top ...
            int[] topIntegers = new int[array.Length];
            int topIntwgersIndex = 0;

            for (int i = 0; i <= array.Length - 1; i++)
            {
                int currentNum = array[i];
                bool isTopInteger = true;

                for (int j = i + 1; j <= array.Length - 1; j++)
                {
                    int nextNum = array[j]; 
                    if (nextNum >= currentNum)
                    {
                        isTopInteger = false;
                        break;
                    }

                }
                if (isTopInteger)
                {
                    topIntegers[topIntwgersIndex] = currentNum;
                    topIntwgersIndex++;
                }
            }
            for (int i = 0; i < topIntwgersIndex; i++)
            {
                Console.Write($"{topIntegers[i]} ");
            }
        }
    }
}
