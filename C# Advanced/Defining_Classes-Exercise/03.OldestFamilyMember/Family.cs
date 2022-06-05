using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.OldestFamilyMember
{
    public class Family
    {
        //----------------- Fields (характеристики) -----------------
        private List<Person> familyMembers;


        //-------------- Constructors --------------
        public Family()
        {
            // трябва задължително да се инициализира за да е нов празен списък а да не е null,
            // ако е null все едно нямаме списък и няма да може да иползваме add, ще хвърли грешка ...
            this.familyMembers = new List<Person>();
        }

        //--------------- Properties ---------------


        //----------------- Methods (фукционалност) ----------------
        public void AddMember(Person member)
        {
            this.familyMembers.Add(member);
        }

        public Person GetOldestMember()
        { 
            int maxAge = this.familyMembers.Max(member => member.Age);
            return this.familyMembers.First(member => member.Age == maxAge);
        }

    }
}
