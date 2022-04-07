using System;

namespace EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                int currentNumber = i;
                int evenSum = 0;
                int oddSum = 0;
                bool isEven = true;

                while (currentNumber > 0)
                {
                    int digit = currentNumber % 10;
                    if (isEven)
                    {
                        evenSum += digit;
                    }
                    else
                    {
                        oddSum += digit;
                    }
                    currentNumber /= 10;
                    isEven = !isEven;
                }
                if (evenSum == oddSum)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
