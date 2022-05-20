using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] elements = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>(elements);

            while (true)
            {
                string command = Console.ReadLine().ToLower();
                string[] commandItems = command.Split(' ');

                if (commandItems[0] == "add")
                {
                    int n1 = int.Parse(commandItems[1]);
                    int n2 = int.Parse(commandItems[2]);
                    stack.Push(n1);
                    stack.Push(n2);
                }
                else if (commandItems[0] == "remove")
                {
                    int count = int.Parse(commandItems[1]);
                    if (stack.Count >= count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
                else if (commandItems[0] == "end")
                {
                    var sum = stack.ToArray().Sum();
                    Console.WriteLine($"Sum: {sum}");
                    break;
                }
            }
        }
    }
}
