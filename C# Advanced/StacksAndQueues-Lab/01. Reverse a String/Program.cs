﻿using System;
using System.Collections.Generic;

namespace _01._Reverse_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();    

            Stack<char> stack = new Stack<char>();

            foreach (char c in inputString)
            { 
            stack.Push(c);
            }

            while (stack.Count > 0)
            { 
            Console.Write(stack.Pop());
            }
        }
    }
}
