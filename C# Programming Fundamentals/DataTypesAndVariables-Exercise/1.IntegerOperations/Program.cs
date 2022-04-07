using System;

namespace _1.IntegerOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int fourthNum = int.Parse(Console.ReadLine());

            long sumOne = (long)firstNum + (long)secondNum;
            long sumTwo = sumOne / thirdNum;
            long sumThree = sumTwo * fourthNum;

            Console.WriteLine(sumThree);

        }
    }
}
