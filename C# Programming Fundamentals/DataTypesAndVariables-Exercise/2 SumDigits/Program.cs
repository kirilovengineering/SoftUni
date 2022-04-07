using System;

namespace _2_SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();

            int n = num.Length;
            int sum = 0;
            int temp = 0;

            for (int i = 0; i <= num.Length - 1; i++)
            {
                temp = (num[i] - 48);
                sum += temp;
            }
            Console.WriteLine(sum);
        }
    }
}
