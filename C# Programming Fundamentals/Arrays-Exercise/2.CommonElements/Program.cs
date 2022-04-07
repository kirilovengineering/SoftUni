using System;
using System.Linq;

namespace _2.CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] first = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(s => s.Trim()).ToArray();
            string[] second = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(s => s.Trim()).ToArray();

            int length = 0;

            if (first.Length > second.Length)
            {
                length = first.Length;
            }
            else
            {
                length = second.Length;
            }

            string[] common = new string[length];

            for (int i = 0; i < first.Length; i++)
            {
                for (int j = 0; j < second.Length; j++)
                {
                    if (first[i] == second[j])
                    {
                        common[j] = first[i];
                    }
                }

            }
            Console.WriteLine(String.Join(" ", common.Where(s => !string.IsNullOrEmpty(s))));
        }
    }
}
