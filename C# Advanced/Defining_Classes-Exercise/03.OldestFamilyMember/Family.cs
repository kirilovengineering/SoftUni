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
            FamilyMembers = new List<Person>();
        }

        //--------------- Properties ---------------
        public List<Person> FamilyMembers { get; set; }

        //----------------- Methods (фукционалност) ----------------
        public void AddMember(Person member)
        {
            this.familyMembers.Add(member);
        }

        public Person GetOldestMember()
        { 
            int maxAge = FamilyMembers.Max(member => member.Age);
            return FamilyMembers.First(member => member.Age == maxAge);
        }

    }
}
