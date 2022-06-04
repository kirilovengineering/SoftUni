using System;

namespace _01._Car
{
    class Car
    {
        private string make;
        private string model;
        private int year;

        public string Make
        { 
            get { return make; }
            set { make = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car ce = new Car();

            ce.Make = "VW";
            ce.Model = "MK3";
            ce.Year = 1992;

            Console.WriteLine($"Make: {ce.Make}\nMoldel: {ce.Model}\nYear: {ce.Year}");
        }
    }
}
