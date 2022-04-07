using System;

namespace _05.AddAndSubtract
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

            int Add = SumFirstTwoIntegers(numbers);
            int Substract = SumFirstTwoIntegersSustractThree(numbers, Add);

            Console.WriteLine(Substract);

        }

        private static int SumFirstTwoIntegers(int[] numbers)
        {
            int sumFirstAndTwo = 0;
            sumFirstAndTwo = numbers[0] + numbers[1];
            return sumFirstAndTwo;
        }
        
        private static int SumFirstTwoIntegersSustractThree(int[] numbers, int Add)
        {
            int substract = Add;
            substract = substract - numbers[2];
            return substract;
        }


    }
}
