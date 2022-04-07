using System;
using System.Collections.Generic;

namespace _07.StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> students = new Dictionary<string, double>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string keyName = Console.ReadLine();
                double valueGrade = double.Parse(Console.ReadLine());
                if (!students.ContainsKey(keyName))
                {
                    students.Add(keyName, valueGrade);
                }
                else
                {
                    students[keyName] = (students[keyName] + valueGrade) / 2;
                }
            }

            foreach (var kvp in students)
            {
                string name = kvp.Key;
                double averageGrade = kvp.Value;

                if (averageGrade >= 4.50)
                {
                    Console.WriteLine($"{name} -> {averageGrade:F2}");
                }

            }

        }
    }
}
