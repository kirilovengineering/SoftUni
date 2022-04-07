using System;

namespace _6.StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int length = number.Length;
            long factorialSum = 0;

            for (int i = 0; i < length; i++)
            {
                int tempNumber = (int)number[i] - 48;

                long tempFactorial = 1;
                for (int n = tempNumber; n > 1; n--)
                {
                    tempFactorial *= n;
                }
                factorialSum += tempFactorial;
            }

            if (factorialSum == int.Parse(number))
            {
                Console.WriteLine($"yes");
            }
            else
            {
                Console.WriteLine($"no");
            }
        }
    }
}
