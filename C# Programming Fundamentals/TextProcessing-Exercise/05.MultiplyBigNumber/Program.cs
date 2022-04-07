using System;
using System.Numerics;

namespace _05.MultiplyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger input = new BigInteger();
            int secondNumber = new int();
            BigInteger output = new BigInteger();

            input = BigInteger.Parse(Console.ReadLine());
            secondNumber = int.Parse(Console.ReadLine());

            output = input * secondNumber;
            Console.WriteLine(output);
        }
    }
}
