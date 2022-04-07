using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lendth = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());
            string count = Console.ReadLine();
            int volume = width * lendth * hight;

            while (count != "Done")
            {
                int countNumber = int.Parse(count);
                volume -= countNumber;
                if (volume < 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(volume)} Cubic meters more.");
                    return;
                }
                count = Console.ReadLine();
            }
            Console.WriteLine($"{volume} Cubic meters left.");
        }
    }
}
