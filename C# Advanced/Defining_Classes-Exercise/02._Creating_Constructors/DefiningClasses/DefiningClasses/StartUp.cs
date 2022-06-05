using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            //Използваме втори и трети конструктор
            person1.Name = "Petar";
            person1.Age = 20;

            Person person2 = new Person(18);

            Person person3 = new Person("George", 43);

            Person person4 = new Person("G", 23);

            // Console.WriteLine(person2.Name); //при Person2 не задаваме име на човечеца и осава без име от първия конструктор по дефолт
            // Console.WriteLine(person2.Age); // ейджа си се предава



        }
    }
}
