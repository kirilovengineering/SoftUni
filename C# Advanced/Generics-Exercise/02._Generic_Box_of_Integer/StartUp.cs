using System;

namespace _02._Generic_Box_of_Integer
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            var numberOfLines = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfLines; i++)
            {
                var input = int.Parse(Console.ReadLine());
                var box = new Box<int>(input);
                Console.WriteLine(box);
            }
        }
    }
}
