using System;

namespace PresentationJaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Jagged arrays are multidimensional arrays
            // But each dimension may have a different size
            // A jagged array is an array of arrays
            // Each of the arrays has different length

            int[][] jagged = new int[2][];
            jagged[0] = new int[3];
            jagged[1] = new int[2];

            // COL   0   1   2  
            // ROW -------------
            //  0  |   |   |   |
            //  1  |   |   |
            //     -------------

            // Accessing elements

            int element = jagged[0/*Row Index*/][1/*Col Index*/];
            // ---------------------------------------------------------------------------------------
 

            // Printing а Jagged Array – Example

            // Using a for loop
            int[][] matrixFor = ReadJaggedArray(); //Implement your custom method
            for (int row = 0; row < matrixFor.Length; row++)
            {
                for (int col = 0; col < matrixFor[row].Length; col++)
                    Console.Write("{0} ", matrixFor[row][col]);
                Console.WriteLine();
            }
            //Using a foreach loop
            int[][] matrixForeach = ReadJaggedArray(); //Implement your custom method
            foreach (int[] row in matrixForeach)
            {
                Console.WriteLine(string.Join(" ", row));
            }



        }
        // Reading a Jagged Array правим като метод за да може да го преизползваме

        // Въвеждаме назъбена матрица с три реда и различен брой колони
        // COL   0   1   2  
        // ROW -------------
        //  0  | 10| 20| 30|
        //  1  | 40|
        //  1  | 50| 60|
        //     -------------

        private static int[][] ReadJaggedArray()
        {
            int rowsCount = int.Parse(Console.ReadLine());
            int[][] jaggedRead = new int[rowsCount][];

            for (int row = 0; row < jaggedRead.Length; row++)
            {
                string[] nums = Console.ReadLine().Split(' ');
                jaggedRead[row] = new int[nums.Length];

                for (int col = 0; col < jaggedRead[row].Length; col++)
                {
                    jaggedRead[row][col] = int.Parse(nums[col]);
                }
            }
            return jaggedRead;
        }

    }
}
