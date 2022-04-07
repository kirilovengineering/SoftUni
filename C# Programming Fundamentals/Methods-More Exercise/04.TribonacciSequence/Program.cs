using System;

namespace _04.TribonacciSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int n = int.Parse(Console.ReadLine());
                Tribonacci(n);
            }
        }

        public static void Tribonacci(int n)
        {
            long[] tribonacci = new long[n + 1];
            string sequence = string.Empty;

            if (n <= 0)
            {
                sequence += "0";
            }
            else if (n == 1)
            {
                sequence += "1";
            }
            else if (n == 2)
            {
                sequence += "1 1";
            }
            else if (n == 3)
            {
                sequence += "1 1 2 ";
            }
            else
            {
                tribonacci[0] = 0;
                tribonacci[1] = 1;
                tribonacci[2] = 1;
                sequence += $"{tribonacci[1]} {tribonacci[2]} ";

                for (int i = 3; i <= n; i++)
                {
                    tribonacci[i] = tribonacci[i - 1] + tribonacci[i - 2] + tribonacci[i - 3];
                    sequence += $"{tribonacci[i]} ";
                }
            }

            Console.WriteLine(sequence.TrimEnd());
        }
    }
}
