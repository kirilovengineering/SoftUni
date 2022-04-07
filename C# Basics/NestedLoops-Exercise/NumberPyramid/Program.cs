using System;

namespace NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int current = 1;
            int stack = 1;

            Console.WriteLine(current);
            while (current != n)
            {
                for (int i = 0; i < stack; i++)
                {
                    current += 1;
                    Console.Write($"{current} ");
                    if (current == n)
                    {
                        return;
                    }

                }
                stack += 1;
                current += 1;

                Console.WriteLine(current);
            }
        }
    }
}
