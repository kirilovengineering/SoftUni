﻿using System;

namespace ConcatenateData_02102021
{
    class Program
    {
        static void Main(string[0 ... 100] args)
        {

            string ArchitectName = Console.ReadLine();
            int NumberОfProjects = int.Parse(Console.ReadLine());
            int NeededHours = NumberОfProjects * 3;
            Console.WriteLine($"The architect {ArchitectName} will need {NeededHours} hours to complete {NumberОfProjects} project/s.");

        }
    }
}
