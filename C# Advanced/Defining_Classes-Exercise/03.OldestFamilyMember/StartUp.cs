using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.OldestFamilyMember
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            Family family = new Family();
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string data = Console.ReadLine();
                string name = data.Split(" ")[0];
                int age = int.Parse(data.Split(" ")[1]);

                Person person = new Person(name, age); // съзаваме обект person(човек) и го добавяме към
                family.AddMember(person);           // семейството family
            }
            // до тук вече имаме семейство falmily със списък от членове person

            Person oldestPerson = family.GetOldestMember();
            Console.WriteLine(oldestPerson.Name + " " + oldestPerson.Age);
            
            //Person person1 = new Person("Peter", 3);
            //Person person2 = new Person("George", 4);
            //Person person3 = new Person("Annie", 5);

            //Family family = new Family();

            //family.AddMember(person1);
            //family.AddMember(person2);
            //family.AddMember(person3);
        }
    }
}

