using System;
using System.Collections.Generic;

namespace _08._Balanced_Parentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<char> parantheses = new Stack<char>();
            string input = Console.ReadLine();
            bool isBalanced = true;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '{' || input[i] == '[' || input[i] == '(')
                {
                    parantheses.Push(input[i]);
                    continue;
                }

                if (parantheses.Count == 0)
                {
                    isBalanced = false;
                    break;
                }

                if (parantheses.Peek() == '(' && input[i] == ')')
                {
                    parantheses.Pop();
                    continue;
                }
                if (parantheses.Peek() == '[' && input[i] == ']')
                {
                    parantheses.Pop();
                    continue;
                }
                if (parantheses.Peek() == '{' && input[i] == '}')
                {
                    parantheses.Pop();
                    continue;
                }
            }

            Console.WriteLine(parantheses.Count == 0 && isBalanced == true ? "YES" : "NO");
        }
    }
}
