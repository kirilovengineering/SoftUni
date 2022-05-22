using System;

namespace IsValidMoveInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Матрицата е правоъглна област от определен брой клетни в дължина и ширина.
            //Матрица с размери row = 5 и col = 7 е матрица със 5 реда и 7 колони:

            int[,] matrix = new int[5, 7];

            int maxRowLength = matrix.GetLength(0);
            int maxColLength = matrix.GetLength(1);

            int row = 2;
            int col = 3;

            string command = Console.ReadLine();

            int stepRow = 0;
            int stepCol = 0;

            while (command != "end")
            {


                switch (command)
                {
                    case "left":
                        stepCol--;
                        break;
                    case "right":
                        stepCol++;
                        break;
                    case "up":
                        stepRow--;
                        break;
                    case "down":
                        stepRow++;
                        break;
                    default:
                        break;
                }

                int newRow = row + stepRow;
                int newCol = col + stepCol;

                if (IsNewPositionValid(maxRowLength, maxColLength, newRow, newCol))
                {
                    // TODO: Изпълнение логиката на задачата

                    row = newRow;
                    col = newCol;
                }

                command = Console.ReadLine();
            }
        }

        private static bool IsNewPositionValid(int maxRowLength, int maxColLength, int newRow, int newCol)
        {
            bool result = ((newRow >= 0) && (newRow < maxRowLength));
            result = ((result) && (newCol >= 0) && (newCol < maxColLength));
            return result;
        }
    }
}
