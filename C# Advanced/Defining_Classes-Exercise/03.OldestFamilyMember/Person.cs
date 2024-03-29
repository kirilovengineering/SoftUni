﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _03.OldestFamilyMember
{
    public class Person
    {
        //----------------- Fields -----------------
        private string name;
        private int age;

        //-------------- Constructors --------------
        public Person()
        {
            this.Name = "No name";
            this.Age = 1;
        }

        public Person(int age) : this()
        {
            this.Age = age;
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        //--------------- Properties ---------------
        public string Name
        {
            get { return this.name; }
            set {
                  /*  if (value.Length > 0 && value.StartsWith("A")) //някаква валидация ..
                    {*/
                        this.name = value; 
                  /*}*/
                }
        }

        public int Age
        {
            get { return this.age; }
            set {  this.age = value; }
        }
    }
}
