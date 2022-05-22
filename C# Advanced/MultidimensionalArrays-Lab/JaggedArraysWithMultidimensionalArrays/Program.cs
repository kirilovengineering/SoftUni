using System;

namespace JaggedArraysWithMultidimensionalArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // first way
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[4];
            jaggedArray[2] = new int[2];

            jaggedArray[0] = new int[] { 1, 3, 5, 7, 9 };
            jaggedArray[1] = new int[] { 0, 2, 4, 6 };
            jaggedArray[2] = new int[] { 11, 22 };

            // second way

            int[][] jaggedArray2 = new int[][]
                {
                new int[] { 1, 3, 5, 7, 9 },
                new int[] { 0, 2, 4, 6 },
                new int[] { 11, 22 }
                };

            //It's possible to mix jagged and multidimensional arrays. The following is a declaration
            //and initialization of a single-dimensional jagged array that contains three two-dimensional
            //array elements of different sizes. For more information, see Multidimensional Arrays.

            int[][,] jaggedArray4 = new int[3][,]
                {
                    new int[,] { {1,3}, {5,7} },
                    new int[,] { {0,2}, {4,6}, {8,10} },
                    new int[,] { {11,22}, {99,88}, {0,9} }
                };

            // Example
            // Declare the array of two elements.
            int[][] arr = new int[2][];

            // Initialize the elements.
            arr[0] = new int[5] { 1, 3, 5, 7, 9 };
            arr[1] = new int[4] { 2, 4, 6, 8 };

            // Display the array elements.
            for (int i = 0; i < arr.Length; i++)
            {
                System.Console.Write("Element({0}): ", i);

                for (int j = 0; j < arr[i].Length; j++)
                {
                    System.Console.Write("{0}{1}", arr[i][j], j == (arr[i].Length - 1) ? "" : " ");
                }
                System.Console.WriteLine();
            }
            // Keep the console window open in debug mode.
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();

            /* Output:
                 Element(0): 1 3 5 7 9
                 Element(1): 2 4 6 8
            */
        }
    }
}
