using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zoo
{
    public class Zoo
    {
        // Fields
        //private List<Animal> animals;
        //private string name;
        //private int capacity;

        //Properites

        public List<Animal> Animals { get; set; } = new List<Animal>();
        // ако го няма този ред колекциата ще е null
        // и акоискаме да добавим накаква колекция ще хвърли грешка
        // ->>> винаги нов за да не остава null
        public string Name { get; set; }
        public int Capacity { get; set; }

        //Constructor

        public Zoo(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
        }

        //Methods

        //1.string AddAnimal(Animal animal) –  adds an Animal to the animals' collection if there is room for it. Before adding an animal, check:
        //1.1. If the animal species is null or whitespace, return "Invalid animal species."
        //1.2. If the animal’s diet is different from "herbivore" or "carnivore", return "Invalid animal diet."
        //1.3. If the zoo is full(there is no room for more animals), return "The zoo is full."
        //1.4. Otherwise, return: "Successfully added {animal species} to the zoo."
        public string AddAnimal(Animal animal)
        {
            if (string.IsNullOrWhiteSpace(animal.Species))
            {
                return "Invalid animal species";
            }
            if (animal.Diet != "herbivore" && animal.Diet != "carnivore")
            {
                return "Invalid animal diet";
            }
            if (Animals.Count >= Capacity)
            {
                return "The zoo is full";
            }
            Animals.Add(animal);
            return $"Successfully added {animal} to the zoo.";
        }

        //2. int RemoveAnimals(string species) – removes all animals by given species, as a result, return the count of the animals which were removed.

        public int RemoveAnimals(string species)
        {
            int count = this.Animals.RemoveAll(a => a.Species == species);
            return count;
        }
        //3. List<Animal> GetAnimalsByDiet(string diet) – search and returns a list of animals by given diet.

        public List<Animal> GetAnimalsByDiet(string diet)
        {
            List<Animal> animals = Animals.Where(a => a.Diet == diet).ToList();
            return animals;
        }

        //4. Animal GetAnimalByWeight(double weight) – return the first animal, with the given weight.
        public Animal GetAnimalByWeight(double weight)
        {
            return Animals.FirstOrDefault(a => a.Weight == weight);
        }

        //5. string GetAnimalCountByLength(double minimumLength, double maximumLength) – search of all animals which has a length between the given (inclusively). As a result return the following format: "There are {count} animals with a length between {minimum length} and {maximum length} meters."

        public string GetAnimalCountByLength(double minimumLength, double maximumLength)
        {
            int count = 0;
            foreach (var an in Animals)
                if (an.Length >= minimumLength && an.Length <= maximumLength)
                {
                    count++;
                }
            return $"There are {count} animals with a length between {minimumLength} and {maximumLength}meters.";



        }

    }
}
