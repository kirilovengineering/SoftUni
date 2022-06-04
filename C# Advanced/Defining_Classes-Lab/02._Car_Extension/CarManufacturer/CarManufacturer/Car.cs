using System;

namespace CarManufacturer
{
    internal class Car
    {
        //----------------- FIELDS -----------------
        private string make;
        private string model;
        private int year;

        //--------------- PROPERTIES ---------------
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
        //----------------- FIELDS -----------------
        private double fuelQuantity;
        //--------------- PROPERTIES ---------------
        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set { fuelQuantity = value; }
        }
        //----------------- FIELDS -----------------
        private double fuelConsumption;
        //--------------- PROPERTIES ---------------
        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }
        //---------------- METHODS -----------------
        public void Drive(double distance)
        {
            double consumtion = distance * this.FuelConsumption;
            if (consumtion <= this.FuelQuantity)
            {
                this.FuelQuantity -= consumtion;
            }
            else 
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoEmI()
        {
            string info =
                $"Make: {this.Make}\r\n" +
                $"Model: {this.Model}\r\n" +
                $"Year: {this.Year}\r\n" +
                $"Fuel: {this.FuelQuantity:F2}L";
            return info;
        }

    }
}
