﻿using System;
using System.Collections.Generic;

namespace _04._Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string expression = Console.ReadLine();
           var stack = new Stack<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                char c = expression[i];
                if (c == '(')
                {
                    stack.Push(i);
                }
                else if (c == ')')
                {
                    int startIndex = stack.Pop();
                    int endIndex = i;
                    string subExpression = expression.Substring(startIndex, endIndex - startIndex +1);
                    Console.WriteLine(subExpression);
                }

            }
        }
    }
}
