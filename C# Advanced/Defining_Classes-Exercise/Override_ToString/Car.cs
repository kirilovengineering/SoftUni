using System;
using System.Collections.Generic;
using System.Text;

namespace Override_ToString
{
    public class Car
    {
        private string make;
        private string model;
        private string powerHorse;
        private string registrationNumber;

        //-------------- Constructors --------------
        public Car(string make, string model, string powerHorse, string registrationNumber)
        {
            this.Make = make;
            this.Model = model;
            this.PowerHorse = powerHorse;
            this.RegistrationNumber = registrationNumber;
        }

        //--------------- Properties ---------------
        public string Make { get; set; }

        public string Model { get; set; }

        public string PowerHorse { get; set; }

        public string RegistrationNumber { get; set; }

        //---------------- Methods -----------------

        // Пренаписваме метода ToString(), който предвтавя обекта като текст.
        // Този метод е вграденмметод във всеки клас кото се представя {име на проекта} {име на класа}

        // override казва, че пренаписваме този метод пп желания от нас начин4

        //public override string ToString()
        //{
        //    return base.ToString();
        //}
        public override string ToString()
        {
            // Изходът ни трябва да изглежда така:
            // "Make : {make}"
            // "Model : {model}"
            // "HorsePower : {horse power}"
            // "RegistrationNumber : {registration number}"

            StringBuilder sb = new StringBuilder();
            sb.Append($"Make : {make}\n");
            sb.Append($"Model : {model}\n");
            sb.Append($"HorsePower : {powerHorse}\n");
            sb.Append($"RegistrationNumber : {RegistrationNumber}");

            return sb.ToString();
        }
    }
}
