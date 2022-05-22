using System;

namespace SomeMothodsForMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //jagged matrix filling in

            int rows = int.Parse(Console.ReadLine());
            int[][] matrix = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                matrix[i] = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }
        }
        private static void MatrixPrintout(string[,] matrix, string splitter)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + splitter);
                }
                Console.WriteLine();
            }
        }


        private static bool VerifyIfIndexIsWithinMatrix(string[,] matrix, int row1, int col1, int row2, int col2)
        {
            //for 2 indexes to validate, remove row2/col2 from arguments and the if-statement below
            if (row1 >= 0 && row1 < matrix.GetLength(0)
                && col1 >= 0 && col1 < matrix.GetLength(1)
                && row2 >= 0 && row2 < matrix.GetLength(0)
                && col2 >= 0 && col2 < matrix.GetLength(1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private static void FillDataIntoMatrix(string[,] matrix, int rows, int cols, string splitter)
        {
            for (int i = 0; i < rows; i++)
            {
                string[] input = Console.ReadLine().Split(splitter,StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = input[j];
                }

            }
        }
    }

}
