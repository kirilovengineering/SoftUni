using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int piecesCount = width * lenght;
            string picesTaken = Console.ReadLine();

            while (picesTaken != "STOP")
            {
                int piecesNumber = int.Parse(picesTaken);
                piecesCount -= piecesNumber;
                if (piecesCount < 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(piecesCount)} pieces more.");
                    return;
                }
                picesTaken = Console.ReadLine();
            }
            Console.WriteLine($"{piecesCount} pieces are left.");
        }
    }
}
