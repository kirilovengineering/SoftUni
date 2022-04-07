using System;
using System.Linq;

namespace _9.KaminoFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sequenceLength = int.Parse(Console.ReadLine());
            string inputCommand = Console.ReadLine();

            int[] DNA = new int[sequenceLength];
            int DNASum = 0;
            int DNACount = -1;
            int DNAStartIndex = -1;
            int DNASample = 0;

            int sample = 0;
            while (inputCommand != "Clone them!")
            {
                sample++;
                int[] currentDNA = inputCommand.Split("!", StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToArray();
                int currentCount = 0;
                int currentStartIndex = 0;
                int currentEndIndex = 0;
                int currentDNASum = 0;
                bool iscurrentDNABetter = false;

                int count = 0;
                for (int i = 0; i < currentDNA.Length; i++)
                {
                    if (currentDNA[i] != 1)
                    {
                        count = 0;
                        continue;
                    }

                    count++;
                    if (count > currentCount)
                    {
                        currentCount = count;
                        currentEndIndex = i;
                    }
                }

                currentStartIndex = currentEndIndex - currentCount + 1;
                currentDNASum = currentDNA.Sum();


                if (currentCount > DNACount)
                {
                    iscurrentDNABetter = true;
                }
                else if (currentCount == DNACount)
                {
                    if (currentStartIndex < DNAStartIndex)
                    {
                        iscurrentDNABetter = true;
                    }
                    else if (currentStartIndex == DNAStartIndex)
                    {
                        if (currentDNASum > DNASum)
                        {
                            iscurrentDNABetter = true;
                        }
                    }
                }

                if (iscurrentDNABetter)
                {
                    DNA = currentDNA;
                    DNACount = currentCount;
                    DNAStartIndex = currentStartIndex;
                    DNASum = currentDNASum;
                    DNASample = sample;
                }

                inputCommand = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {DNASample} with sum: {DNASum}.");
            Console.WriteLine(String.Join(" ", DNA));

        }
    }
}
