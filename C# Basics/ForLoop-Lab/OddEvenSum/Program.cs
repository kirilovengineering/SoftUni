using System;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumEven = 0;
            int sumOdd = 0;
            int num = 0;
            int trigger = 0;

            for (int i = 0; i < n; i++)
            {
                num = int.Parse(Console.ReadLine());
                trigger = i % 2;

                if (trigger == 0)
                {
                    sumEven += num;
                }
                else
                {
                    sumOdd += num;
                }
            }

            if (sumEven == sumOdd)
            {
                Console.WriteLine($"Yes");
                Console.WriteLine($"Sum = {sumEven}");
            }
            else
            {
                Console.WriteLine($"No");
                Console.WriteLine($"Diff = {Math.Abs(sumEven - sumOdd)}");
            }
        }
    }
}
