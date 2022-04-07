using System;

namespace CharacterSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string horizontal = Console.ReadLine();
            char letter;
            int n = 0;
            n = horizontal.Length;

            for (int i = 0; i < n; i++)
            {
                letter = horizontal[i];
                Console.WriteLine(letter);
            }
        }
    }
}
