using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheRace
{
    public class Race
    {
        private List<Racer> data;
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count => data.Count;

        public Race(string name, int capacity)
        {
            data = new List<Racer>();  //this.data = data;
            Name = name;
            Capacity = capacity;
        }

        public void Add(Racer racer)//– adds an entity to the data if there is room for him/her.
        {
            if (Count < Capacity)
            {
                data.Add(racer);
            }
        }

        public bool Remove(string name)//– removes an Racer by given name, if such exists, and returns bool.
        {
            return data.Remove(data.Find(x => x.Name == name));
        }

        public Racer GetOldestRacer()//– returns the oldest Racer.
        {
            int biggestAge = data.Select(r => r.Age).Max();
            return data.Find(x => x.Age == biggestAge);
        }

        public Racer GetRacer(string name)//– returns the Racer with the given name.
        {
            return data.Find(r => r.Name == name);
        }

        public Racer GetFastestRacer()//– returns the Racer whose car has the highest speed.
        {
            int topSpeed = 0;
            Racer fastest = null;
            foreach (var racer in data)
            {
                if (racer.Car.Speed > topSpeed)
                {
                    topSpeed = racer.Car.Speed;
                    fastest = racer;
                }
            }
            return fastest;
        }

        public string Report()//-– returns a string in the following format:
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Racers participating at {Name}:");
            foreach (var racer in data)
            {
                output.AppendLine(racer.ToString());
            }

            return output.ToString().TrimEnd();
        }
    }
}
