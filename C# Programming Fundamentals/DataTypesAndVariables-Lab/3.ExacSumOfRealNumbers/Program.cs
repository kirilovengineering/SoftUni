using System;

namespace _3.ExacSumOfRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            //System.Numerics.BigInteger sum = 0;

            //for (int i = 1; i <= n; i++)
            //{
               
            //    sum += System.Numerics.BigInteger.Parse(Console.ReadLine());

            //}
            //Console.WriteLine(sum);

            var numberOfNumbers = decimal.Parse(Console.ReadLine());
            var sum = 0m;

            for (int i = 0; i < numberOfNumbers; i++)
            {
                sum += decimal.Parse(Console.ReadLine());
            }

            Console.WriteLine(sum);

        }
    }
}
