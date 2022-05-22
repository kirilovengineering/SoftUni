using System;
using System.Linq;

namespace PresentationMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Multidimensional Arrays
            // 1.Creating Matrices and Multidimensional Arrays
            // 2.Accessing Their Elements
            // 3.Reading and Printing

            // Creating Multidimensional Arrays

            int[,] intMatrix = new int[3, 4];
            // COL   0   1   2   3  
            // ROW -----------------
            //  0  |   |   |   |   |
            //  1  |   |   |   |   |
            //  2  |   |   |   |   |
            //     -----------------
            float[,] floatMatrix = new float[8, 2];
            string[,,] stringCube = new string[5, 5, 5];

            // Initializing with values:

            int[,] matrix = {
                                {1, 2, 3, 4}, // row 0 values
                                {5, 6, 7, 8}  // row 1 values
                            };

            // Accessing N-dimensional array element:
            // nDimensionalArray[index1, … , indexn]

            // Getting element value:

            int[,] array = { { 10, 20, 30 }, { 40, 50, 60 } };
            int element10 = array[1, 0]; // element10 = 40

            // COL   0   1   2  
            // ROW -------------
            //  0  | 10| 20| 30|
            //  1  | 40| 50| 60|
            //     -----------------

            // Setting element value:

            int[,] arrayFeelinWithSumOfIndex = new int[3, 4];
            for (int row = 0; row < array.GetLength(0)/* Returns the size of the dimension*/; row++)
            {
                for (int col = 0; col < array.GetLength(1)/* Returns the size of the dimension*/; col++)
                {
                    array[row, col] = row + col;
                }
            }

            // Printing a Matrix – Example(1)

            int[,] matrixForPrintWithFor =
                {  { 5, 2, 3, 1 },
                   { 1, 9, 2, 4 },
                   { 9, 8, 6, 11 }  
                };
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0} ", matrix[row, col]);
                }

                Console.WriteLine();
            }

            // Printing Matrix – Example(2) - Foreach iterates through all the elements in the matrix

            int[,] matrixmatrixForPrintWithForeach = 
                {
                  { 5, 2, 3, 1 },
                  { 1, 9, 2, 4 },
                  { 9, 8, 6, 9 }
                };

            foreach (int element in matrix)
            {
                Console.WriteLine(element + " ");
            }

            // Problem Sum Matrix Elements

            int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrixSum = new int[sizes[0], sizes[1]];
            for (int row = 0; row < matrixSum.GetLength(0)/*Gets length of 0th  dimension (rows)*/; row++)
            {
                int[] colElements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1)/*Gets length of 1st dimension (cols)*/; col++)
                    matrixSum[row, col] = colElements[col];
            }
            int sum = 0;
            for (int row = 0; row < matrixSum.GetLength(0); row++)
            {
                for (int col = 0; col < matrixSum.GetLength(1); col++)
                    sum += matrix[row, col];
            }
            Console.WriteLine(matrixSum.GetLength(0));
            Console.WriteLine(matrixSum.GetLength(1));
            Console.WriteLine(sum);

            // Problem: Sum Matrix Columns

            var sizesMC = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrixSumColumns = new int[sizesMC[0], sizesMC[1]];
            for (int r = 0; r < matrixSumColumns.GetLength(0); r++)
            {
                var col = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int c = 0; c < matrixSumColumns.GetLength(1); c++)
                {
                    matrixSumColumns[r, c] = col[c];
                }
            }
            for (int c = 0; c < matrixSumColumns.GetLength(1); c++)
            {
                int sumMC = 0;
                for (int r = 0; r < matrixSumColumns.GetLength(0); r++)
                {
                    sumMC += matrixSumColumns[r, c];
                }
                Console.WriteLine(sumMC);
            }



        }
    }
}
