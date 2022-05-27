﻿namespace MergeFiles
{
    using System;
    using System.IO;
    public class MergeFiles
    {
        static void Main(string[] args)
        {
            var firstInputFilePath = @"../../../Files/input1.txt";
            var secondInputFilePath = @"../../../Files/input2.txt";
            var outputFilePath = @"../../../Files/output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            string[] file1 = File.ReadAllLines(firstInputFilePath);
            string[] file2 = File.ReadAllLines(secondInputFilePath);
            
            StreamWriter writer = new StreamWriter(outputFilePath);
            using (writer)
            {
                int lineNumber = 0;
                while (lineNumber < file1.Length || lineNumber < file2.Length)
                {
                    if (lineNumber < file1.Length)
                    {
                        writer.WriteLine(file1[lineNumber]);
                    }

                    if (lineNumber < file2.Length)
                    {
                        writer.WriteLine(file2[lineNumber]);
                    }

                    lineNumber++;
                }
            }
        }

    }
}
