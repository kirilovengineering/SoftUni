using System;

namespace _02._Pawn_Wars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 8;
            char[,] matrix = new char[size, size];
            string[,] matrixNamesOfCordinates = new string[size, size];
            // запълваме матрицата с имаената на квадратите на шахматната дъска
            int rowName = size;
            for (int r = 0; r < size; r++)
            {
                rowName--;
                int colNames = 0;
                for (char ch = 'a'; ch <= 'h'; ++ch)
                {
                    string coordinates = ch.ToString() + $"{r + 1}";
                    matrixNamesOfCordinates[rowName, colNames] = coordinates;
                    colNames++;
                }

            }

            int tempRow_b = 0;
            int tempCol_b = 0;
            int tempRow_w = 0;
            int tempCol_w = 0;
            // Запълваме матрицата с входа
            for (int row = 0; row < size ; row++)
            {
                char[] curremtRowElements = Console.ReadLine().Replace(" ", string.Empty).ToCharArray();
                //  премахваме интервалите.ToCharArray() - символен масив

                for (int col = 0; col < curremtRowElements.Length; col++)
                {
                    matrix[row, col] = curremtRowElements[col];
                    if (curremtRowElements[col] == 'b')
                    {
                        tempRow_b = row;
                        tempCol_b = col;
                    }
                    if (curremtRowElements[col] == 'w')
                    {
                        tempRow_w = row;
                        tempCol_w = col;
                    }
                }

            }

            do
            {
            //---------------------------------------------------------------------------------------
            // движение на бялата, ако има черна пешка в ляво
            if ((tempRow_b == tempRow_w - 1) && (tempCol_b == tempCol_w - 1))
            {
                Console.WriteLine($"Game over! White capture on {matrixNamesOfCordinates[tempRow_w - 1,tempCol_w - 1]}.");
                    matrix[tempRow_w - 1, tempCol_w - 1] = 'w';
                    //маркираме предходната позиция с "-"
                    matrix[tempRow_w, tempCol_w] = '-';
                    break;
                }
            // движение на бялата, ако има черна пешка в дясно
            if ((tempRow_b == tempRow_w - 1) && (tempCol_b == tempCol_w + 1))
            {
                Console.WriteLine($"Game over! White capture on {matrixNamesOfCordinates[tempRow_w - 1, tempCol_w + 1]}.");
                    matrix[tempRow_w - 1, tempCol_w + 1] = 'w'; 
                    //маркираме предходната позиция с "-"
                    matrix[tempRow_w, tempCol_w] = '-';
                    break;
                }
            //маркираме предходната позиция с "-"
            matrix[tempRow_w, tempCol_w] = '-';
            // движение на бялата пешка напред, ако няма черна пешка в ляво или в дясно
            tempRow_w--;
            // маркираме новата позиция с w
            matrix[tempRow_w, tempCol_w] = 'w';

            // ако пешката е стигнала края става царица
            if (tempRow_w == 0)
            {
                Console.WriteLine($"Game over! White pawn is promoted to a queen at {matrixNamesOfCordinates[tempRow_w, tempCol_w]}.");
                    matrix[tempRow_w, tempCol_w] = 'w';break;
            }
             //PrintMatrix(matrix); Console.WriteLine();
            //---------------------------------------------------------------------------------------
            // движение на черната, ако има бяла пешка в ляво
            if ((tempRow_b + 1 == tempRow_w) && (tempCol_b - 1 == tempCol_w))
            {
                Console.WriteLine($"Game over! Black capture on {matrixNamesOfCordinates[tempRow_b + 1, tempCol_b - 1]}.");
                    matrix[tempRow_b + 1, tempCol_b - 1] = 'b';
                    // маркираме старата позиция с "-"
                    matrix[tempRow_b, tempCol_b] = '-';
                    break;
            }
            // движение на черната, ако има бяла пешка в дясно
            if ((tempRow_b + 1 == tempRow_w) && (tempCol_b + 1 == tempCol_w))
            {
                Console.WriteLine($"Game over! Black capture on {matrixNamesOfCordinates[tempRow_w + 1, tempCol_w + 1]}.");
                    matrix[tempRow_w + 1, tempCol_w + 1] = 'b';
                    // маркираме старата позиция с "-"
                    matrix[tempRow_b, tempCol_b] = '-';
                    break;
                }
            // маркираме старата позиция с "-"
            matrix[tempRow_b, tempCol_b] = '-';
            // движение на черната пешка напред, ако няма бяла пешка в ляво или в дясно
            tempRow_b++;
            matrix[tempRow_b, tempCol_b] = 'b';

            // ако пешката е стигнала края става царица
            if (tempRow_b == 7)
            {
                Console.WriteLine($"Game over! Black pawn is promoted to a queen at {matrixNamesOfCordinates[tempRow_b, tempCol_b]}.");
                    matrix[tempRow_b, tempCol_b] = 'b'; break;
                }

                //PrintMatrix(matrix);Console.WriteLine();

            } while (tempRow_w != 0 || tempRow_b != 7);


            //PrintMatrix(matrix);
            //PrintMatrixM(matrixNamesOfCordinates);
        }

        //private static void PrintMatrix(char[,] matrix)
        //{
        //    for (int row = 0; row < matrix.GetLength(0); row++)
        //    {
        //        for (int col = 0; col < matrix.GetLength(0); col++)
        //        {
        //            Console.Write(matrix[row, col] + " ");
        //        }
        //        Console.WriteLine();
        //    }
        //}


        //private static void PrintMatrixM(string[,] matrix)
        //{
        //    for (int row = 0; row < matrix.GetLength(0); row++)
        //    {
        //        for (int col = 0; col < matrix.GetLength(0); col++)
        //        {
        //            Console.Write(matrix[row, col] + " ");
        //        }
        //        Console.WriteLine();
        //    }
        //}
    }
}
