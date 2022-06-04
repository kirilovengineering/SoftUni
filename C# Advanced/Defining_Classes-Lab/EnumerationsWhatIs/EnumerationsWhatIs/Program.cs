using System;

namespace EnumerationsWhatIs
{
    internal class Program
    {
        enum CoffeeSize
        {
            Small = 100,
            Normal = 150,
            Double = 300
        }
        enum Day
        {
            // By default enums start at 0

            Mon = 1,//като зададем стойност на първия следващте се инкреметират, иначе започва от нула
            Tue,  // 2
            Wed = 4,  // 3 // ако прескочим ииндекс, икрементирането нататък става от зададения индекс
            Thu,  // 4 
            Fri,  // 5 
            Sat  = 8,  // 6 
            Sun   // 7
        }

        enum Days
        { Mon = 1, Tue, Wed, Thu, Fri, Sat, Sun }



        static void Main(string[] args)
        {
            // Самият ден
            Days c = Days.Tue;
            Console.WriteLine(c);
            //Стойността зададена на mon
            Days d = Days.Mon;
            Console.WriteLine(((double)d));


        }

    }
}
