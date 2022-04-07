using System;

namespace _03.CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char charStart = char.Parse(Console.ReadLine());
            char charEnd = char.Parse(Console.ReadLine());

            if (charStart >= charEnd)
            {
                char temp;   
                temp = charEnd;   
                charEnd = charStart;
                charStart = temp;
            }
  

            for (char i = (char)(((int)charStart) + 1); i < charEnd; i++)
            {
                Console.Write($"{i} ");
            }

        }
    }
}
