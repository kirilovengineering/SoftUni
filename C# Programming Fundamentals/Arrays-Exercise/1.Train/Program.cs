using System;

namespace _1.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] train = new int[n];

            int sumPassengers = 0;

            for (int i = 0; i < train.Length; i++)
            {
                train[i] = int.Parse(Console.ReadLine());
                sumPassengers += train[i];
            }

            for (int i = 0; i < train.Length; i++)
            {
                Console.Write($"{train[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine(sumPassengers);

        }
    }
}
