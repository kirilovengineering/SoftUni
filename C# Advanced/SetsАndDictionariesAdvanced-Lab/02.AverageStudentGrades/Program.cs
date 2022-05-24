using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AverageStudentGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var studentGrades = new Dictionary<string, List<decimal>>();
            int gradesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < gradesCount; i++)
            {
                string[] liine = Console.ReadLine().Split(' ');
                string name = liine[0];
                decimal grade = decimal.Parse(liine[1]);
                if (!studentGrades.ContainsKey(name)) 
                    // работи и без бракетс и елс когато има по едно действие
                    //{
                    studentGrades.Add(name, new List<decimal>());
                    //}
                    //else
                    //{
                studentGrades[name].Add(grade);
                    //}   
            }

            foreach (var name in studentGrades.Keys)
            {
                List<decimal> grades = studentGrades[name];
                string gradesString = string.Join(" ", grades.Select(g => g.ToString("f2")));
                decimal avg = studentGrades[name].Average();
                Console.WriteLine($"{name} -> {gradesString} (avg: {avg:f2})");
            }
        }
    }
}
