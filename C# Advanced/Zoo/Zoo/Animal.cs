using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Animal
    {
        //Fields

        private string species;
        private string diet;
        private double weight;
        private double length;

        //Properites
        public string Species { get => species; set => species = value; }
        public string Diet { get => diet; set => diet = value; }
        public double Weight { get => weight; set => weight = value; }
        public double Length { get => length; set => length = value; }

        public Animal(string species, string diet, double weight, double length)
        {
            Species = species;
            Diet = diet;
            Weight = weight;
            Length = length;
        }

        public override string ToString()
        {
            return $"The {Species} is a {Diet} and weighs {Weight} kg.";


        }
    }
}
