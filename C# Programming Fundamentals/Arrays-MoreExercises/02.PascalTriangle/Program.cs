using System;

namespace _02.PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int value = 1;

            for (int row = 0; row < n; row++)
            {
                for (int column = 0; column <= row; column++)
                {
                    if (column == 0 || row == 0)
                    {
                        value = 1;
                    }
                    else
                    {
                        value = value * (row - column + 1) / column;
                    }

                    if (column < row)
                    {
                        Console.Write(value + " ");
                    }
                    else
                    {
                        Console.Write(value + "");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}