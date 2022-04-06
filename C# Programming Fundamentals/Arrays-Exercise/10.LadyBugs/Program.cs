using System;
using System.Linq;

namespace _10.LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] ladyBugsIndexes = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            //Initialize the field
            int[] field = new int[fieldSize];
            for (int index = 0; index < fieldSize; index++)
            {
                //If index is present in ladyBugsIndexes then where is a ladybug
                if (ladyBugsIndexes.Contains(index))
                {
                    field[index] = 1;
                }
            }
            string command;
            while ((command = Console.ReadLine()) != "end")
            {

                string[] cmdArgs = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                int initilIndex = int.Parse(cmdArgs[0]);      
                string directions = cmdArgs[1];
                int flyLength = int.Parse(cmdArgs[2]);

                // First always check if index is valid !!!
                if (initilIndex < 0 || initilIndex >= field.Length)
                {
                    //Nothing happens, next iterationa (command)
                    //Skips the command
                    continue;
                }

                //We have valid index, then we check if there is aladybug

                if (field[initilIndex] == 0) //If there is not a ladybug
                {
                    continue;
                }

                //Ladybug start flying
                //Initial set index to 0, no ladybugs anymore
                field[initilIndex] = 0;

                //Calculate where is the nex index
                int nextIndex = initilIndex;
                while (true)
                {
                    if (directions == "right")
                    {
                        nextIndex += flyLength;
                    }
                    else if (directions == "left")
                    {
                        nextIndex -= flyLength;
                    }
                    
                    if (nextIndex < 0 || nextIndex >= field.Length)
                    {
                        // Next index is invalid (outside of the field)
                        //Ladybug is gone int the void
                        break;
                    }

                    if (field[nextIndex] == 0)
                    {
                        //The next index is empty and is valid to land
                        //Then we lend the ladybug
                        break;
                    }
                }

                if (nextIndex >= 0 && nextIndex < field.Length)
                {
                    //The next calcualted index is valid
                    //The ladybug lad here
                    field[nextIndex] = 1;
                }
            }
            Console.WriteLine(String.Join(" ", field));
        }
    }
}
