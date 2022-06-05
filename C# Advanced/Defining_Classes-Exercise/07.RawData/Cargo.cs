using System;
using System.Collections.Generic;
using System.Text;

namespace _07.RawData
{
    public class Cargo
    {
        //-------------- Constructors --------------
        public Cargo(int weight, string type)
        {
            this.Weight = weight;
            this.Type = type;
        }

        //--------------- Properties ---------------
        public int Weight { get; private set; }

        public string Type { get; private set; }
    }
}
