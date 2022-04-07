using System;
using System.Collections.Generic;

namespace _04.Students
{
    class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }    

        public int Age { get; set; }

        public string HomeTown { get; set; }     
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Student> students = new List<Student>();

            while (command != "end")
            {
                string[] lineParameters = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Student student = new Student()
                {
                    FirstName = lineParameters[0],
                    LastName = lineParameters[1],
                    Age = int.Parse(lineParameters[2]),
                    HomeTown = lineParameters[3]

                };
                students.Add(student);

                command = Console.ReadLine();
            }

            string town = Console.ReadLine();
            var filteredStudents = students.FindAll(student => student.HomeTown == town);

            foreach (Student student in filteredStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }
}
