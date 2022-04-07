using System;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int apartments = int.Parse(Console.ReadLine());

            for (int floor = floors; floor >= 1; floor--)
            {
                for (int apartment = 0; apartment < apartments; apartment++)
                {
                    if (floor == floors)
                    {
                        Console.Write($"L{floor}{apartment} ");
                    }
                    else if (floor % 2 == 0)
                    {
                        Console.Write($"O{floor}{apartment} ");
                    }
                    else
                    {
                        Console.Write($"A{floor}{apartment} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
