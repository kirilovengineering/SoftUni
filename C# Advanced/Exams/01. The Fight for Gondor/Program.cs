using System;
using System.Collections.Generic;
using System.Linq;
//https://github.com/IvalinaNenova/SoftUni-Courses/tree/main/Advanced/Exam%20Practice
namespace _01._The_Fight_for_Gondor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int waves = int.Parse(Console.ReadLine());
            int[] startPlates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var orcs = new Stack<int>();
            var plates = new LinkedList<int>(startPlates);

            for (int i = 1; i <= waves; i++)
            {
                int[] readOrcs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                if (!plates.Any() && i % 3 != 0)
                {
                    break;
                }
                orcs = new Stack<int>(readOrcs);
                if (i % 3 == 0)
                {
                    plates.AddLast(int.Parse(Console.ReadLine()));
                }

                while (plates.Any() && orcs.Any())
                {
                    int orcPower = orcs.Pop();
                    int plate = plates.First();
                    plates.RemoveFirst();
                    if (plate > orcPower)
                    {
                        plate -= orcPower;
                        plates.AddFirst(plate);

                    }
                    else if (plate < orcPower)
                    {
                        orcPower -= plate;
                        orcs.Push(orcPower);
                    }
                }

                if (!plates.Any())
                {
                    break;
                }
            }

            Console.WriteLine(plates.Any()
                ? $"The people successfully repulsed the orc's attack.\nPlates left: {string.Join(", ", plates)}"
                : $"The orcs successfully destroyed the Gondor's defense.\nOrcs left: {string.Join(", ", orcs)}");
        }
    }
}
