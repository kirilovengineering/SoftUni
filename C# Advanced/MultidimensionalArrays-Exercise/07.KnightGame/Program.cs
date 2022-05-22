using System;

namespace _07.KnightGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //You will receive a board with K for knights and '0' for empty cells.
            //Your task is to remove a minimum of the knights,
            //so there will be no knights left that can attack another knight.
            //Конят се придвижва до най-близкото поле, но не на същия ред, колона или диагонал.
            //(Това може да се мисли като преместване на два квадрата хоризонтално,
            //след това един квадрат вертикално, или преместване на един квадрат хоризонтално,
            //след това два квадрата вертикално – т.е. в „L“ модел.)
            //Играта на рицар се играе на дъска с размери N x N и много шах рицари(офицери) 0 <= K <= N2.
            //Ще получите дъска с 'K' рицари и '0' за празни клетки.
            //Вашата задача е да премахнете минимум рицари,
            //така че да не останат рицари, които да атакуват друг рицар.

            //Output
            //Print a single integer with the minimum number of knights that needs to be removed


            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] rowElements = Console.ReadLine().ToCharArray();
                for (int i = 0; i < matrix.GetLength(1); i++)
                {
                    matrix[row, i] = rowElements[i];
                }
            }     
                                                                          //   Невалидни полета   
                                                                          //       0   1   2   3   4   COL
            int attackableKnights = 0;                                    // ROW ---------------------                                      
            int maxAttackableKnights = -1;                                //  0  |   | X |   | X |   |      K --> Knight
            int bestKnightRow = 0;                                        //  1  | X |   |   |   | X |      X --> Attackable Unit (Other Knight)
            int bestKnightCol = 0;                                        //  2  |   |   | K |   |   |
            int count = 0;                                                //  3  | X |   |   |   | A |
                                                                          //  4  |   | X |   | X |   |
            while (true)                                                  //     ---------------------
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int i = 0; i < matrix.GetLength(1); i++)
                    {
                        if (matrix[row, i] == 'K')
                        {
                            //--------- 1 row UNDER ---------
                            if (row + 1 < matrix.GetLength(0))
                            {
                                if (i - 2 >= 0)
                                {
                                    if (matrix[row + 1, i - 2] == 'K')
                                    {
                                        attackableKnights++;
                                    }
                                }

                                if (i + 2 < matrix.GetLength(1))
                                {
                                    if (matrix[row + 1, i + 2] == 'K')
                                    {
                                        attackableKnights++;
                                    }
                                }
                            }

                            //--------- 1 row UP ---------
                            if (row - 1 >= 0)
                            {
                                if (i - 2 >= 0)
                                {
                                    if (matrix[row - 1, i - 2] == 'K')
                                    {
                                        attackableKnights++;
                                    }
                                }

                                if (i + 2 < matrix.GetLength(1))
                                {
                                    if (matrix[row - 1, i + 2] == 'K')
                                    {
                                        attackableKnights++;
                                    }
                                }
                            }
                            //--------- 2 rows UNDER ---------
                            if (row + 2 < matrix.GetLength(0))
                            {
                                if (i + 1 < matrix.GetLength(1))
                                {
                                    if (matrix[row + 2, i + 1] == 'K')
                                    {
                                        attackableKnights++;
                                    }
                                }

                                if (i - 1 >= 0)
                                {
                                    if (matrix[row + 2, i - 1] == 'K')
                                    {
                                        attackableKnights++;
                                    }
                                }
                            }

                            //--------- 2 rows UP ---------
                            if (row - 2 >= 0)
                            {
                                if (i + 1 < matrix.GetLength(1))
                                {
                                    if (matrix[row - 2, i + 1] == 'K')
                                    {
                                        attackableKnights++;
                                    }
                                }

                                if (i - 1 >= 0)
                                {
                                    if (matrix[row - 2, i - 1] == 'K')
                                    {
                                        attackableKnights++;
                                    }
                                }
                            }
                        }

                        if (attackableKnights > maxAttackableKnights)
                        {
                            maxAttackableKnights = attackableKnights;
                            bestKnightRow = row;
                            bestKnightCol = i;
                        }
                        attackableKnights = 0;
                    }
                }

                if (maxAttackableKnights != 0)
                {
                    matrix[bestKnightRow, bestKnightCol] = '0';
                    maxAttackableKnights = 0;
                    count++;
                }
                else
                {
                    Console.WriteLine(count);
                    return;
                }
            }
        }
    }
}
