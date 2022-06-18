using System;

namespace _02.TruffleHunter
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int size = int.Parse(Console.ReadLine()); // размер на гората/матрицата
            // матрица от символи
            char[,] matrix = new char[size, size]; // мсив от символи

            //съхранение на броя трюфели по видове
            int countBlack = 0;
            int countSummer = 0;
            int countWhite = 0;
            int eaten = 0; //брой изядени трюфели

            //пълнене на матрицата
            for (int row = 0; row <= size - 1; row++)
            {
                char[] curremtRowElements = Console.ReadLine().Replace(" ", string.Empty).ToCharArray();
                // B W S - -   -Replace> BWS--  премахваме интервалите.ToCharArray() - символен масив

                for (int col = 0; col < curremtRowElements.Length; col++)
                {
                    matrix[row, col] = curremtRowElements[col];
                }

            }
            //получваме команди
            string command = Console.ReadLine();

            while (command != "Stop the hunt")
            {
                //командите са :
                //1. "Collect {row} {col}".Split -> ["Collect", "{row}", "{col}" ]
                //2. "Wild_Boar {row} {col} {direction}".Split -> ["Collect", "{row}", "{col}", "{direction}" ]  
                string commandName = command.Split()[0];
                int row = int.Parse(command.Split()[1]);
                int col = int.Parse(command.Split()[2]);
                // "{direction}" ще обработим само ако сме в точка 2."Wild_Boar" иначе нама да е достъпен [3]
                if (commandName == "Collect")
                {
                    //вземаме трюфел на един от вариянтите B, S, W
                    char truffel = matrix[row, col];
                    matrix[row, col] = '-';
                    if (truffel == 'B')
                    {
                        countBlack++;
                    }
                    else if (truffel == 'S')
                    {
                        countSummer++;
                    }
                    else if (truffel == 'W')
                    {
                        countWhite++;
                    }
                }

                else if (commandName == "Wild_Boar")
                {
                    string direction = command.Split()[3];
                    // вариянтите на командата са "up", "down", "left" and "right".

                    switch (direction)
                    {
                        case "up":
                            //докъто има редове нагоре
                            while (IsValidRow(row, size))
                            {
                                //проверка дали през мястото където минава има трюфел
                                if (EatBoar(row, col, matrix))
                                {
                                    eaten++;
                                }
                                //при движение нагоре пропускаме един ред по условие, колоната остава същия , не се бара :)
                                row -= 2;
                            }
                            break;
                        case "down":
                            //докъто има редове надолу
                            while (IsValidRow(row, size))
                            {
                                //проверка дали през мястото където минава има трюфел
                                if (EatBoar(row, col, matrix))
                                {
                                    eaten++;
                                }
                                //при движение надолу пропускаме един ред по условие, колоната остава същия , не се бара :)
                                row += 2;
                            }
                            break;
                        case "left":
                            //докъто има колони наляво
                            while (IsValidCol(col, size))
                            {
                                //проверка дали през мястото където минава има трюфел
                                if (EatBoar(row, col, matrix))
                                {
                                    eaten++;
                                }
                                //при движение наляво пропускаме една колона по условие, реда остава същия , не се бара :)
                                col -= 2;
                            }
                            break;
                        case "right":
                            //докъто има колони надясно
                            while (IsValidCol(col, size))
                            {
                                //проверка дали през мястото където минава има трюфел
                                if (EatBoar(row, col, matrix))
                                {
                                    eaten++;
                                }
                                //при движение надясно пропускаме една колона по условие, реда остава същия , не се бара :)
                                col += 2;
                            }
                            break;

                    }
                }
                command = Console.ReadLine();
            }

            // След като сме получили "Stop the hunt" отпечатваме
            //"Peter manages to harvest {count black truffles} black, {count summer truffles} summer, and {count white truffles} white truffles."
            //"The wild boar has eaten {count of truffles} truffles."

            Console.WriteLine($"Peter manages to harvest {countBlack} black, {countSummer} summer, and {countWhite} white truffles.");
            Console.WriteLine($"The wild boar has eaten {eaten} truffles.");

            PrintMatrix(matrix);
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(0); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        //false -ако е изял трюфел
        //true -аконе е изял рюфел
        private static bool EatBoar(int row, int col, char[,] matrix)
        {
            char currentSymbol = matrix[row, col];
            if (currentSymbol == 'B' || currentSymbol == 'S' || currentSymbol == 'W')
            {
                //т.е. ако има трюфел изяжда трюфела, заменя го с тире и връща true
                matrix[row, col] = '-';
                return true;
            }
            return false;
        }

        public static bool IsValidRow(int row, int size)
        //проверяваме дали подадения ред е в матрицата
        {
            return row >= 0 && row < size;
        }
        public static bool IsValidCol(int col, int size)
        //проверяваме дали подадения колона е в матрицата
        {
            return col >= 0 && col < size;
        }
    }
}
