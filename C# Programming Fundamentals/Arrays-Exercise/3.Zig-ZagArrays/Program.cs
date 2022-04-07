using System;
using System.Linq;

namespace _3.Zig_ZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] zig = new int[n];
            int[] zag = new int[n];

            for (int row = 1; row <= n; row++)
            {
                int[] currentRowData = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                int firstNumber = currentRowData[0];
                int secomNumber = currentRowData[1];

                if (row % 2 != 0)
                {
                    zig[row - 1] = firstNumber;
                    zag[row - 1] = secomNumber;
                }
                else
                {
                    zig[row - 1] = secomNumber;
                    zag[row - 1] = firstNumber;
                }
            }
            Console.WriteLine(String.Join(" ", zig));
            Console.WriteLine(String.Join(" ", zag));
        }
    }
}
