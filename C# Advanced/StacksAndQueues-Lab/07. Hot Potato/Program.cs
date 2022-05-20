using System;

namespace _07._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var players = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var queue = new Queue<string>(players);
            int n = int.Parse(Console.ReadLine());

            while (queue.Count > 1)
            {
                for (int i = 1; i <= n - 1; i++)
                {
                    var player = queue.Dequeue();
                    queue.Enqueue(player);
                }
                var lostPlayer = queue.Dequeue();
                Console.WriteLine($"Removed {lostPlayer}");
            }
            var lastPlayer = queue.Dequeue();
            Console.WriteLine($"Last is {lastPlayer}");
        }
    }
}
