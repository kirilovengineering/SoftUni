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

            // COL   0   1   2   3   4   
            // ROW ---------------------
            //  0  |   | X |   | X |   |
            //  1  | X |   |   |   | X |
            //  2  |   |   | K |   |   |
            //  3  | X |   |   |   | A |
            //  4  |   | X |   | X |   |
            //     ---------------------

        }
    }
}
