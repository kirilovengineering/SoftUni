using System;

namespace _4.SumOfChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n =  int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                char currentCh = char.Parse(Console.ReadLine());
                int currentChCode = (int)currentCh;

                sum += currentChCode;
            }

            Console.WriteLine($"The sum equals: {sum}");

        }
    }
}
