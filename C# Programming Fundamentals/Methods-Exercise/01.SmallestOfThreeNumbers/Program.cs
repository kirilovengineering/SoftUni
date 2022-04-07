using System;
using System.Linq;

namespace _01.SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int smallNumber = FindSmallestNumber(numbers);
            Console.WriteLine(smallNumber); 

        }

        private static int FindSmallestNumber(int[] numbers)
        {
            int minValue = int.MaxValue;
            foreach (int num in numbers)
            {
                if (num < minValue)
                {
                    minValue = num;
                }
            }
            return minValue;    
        }
    }
}
