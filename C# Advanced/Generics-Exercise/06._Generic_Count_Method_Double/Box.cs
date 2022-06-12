﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _06._Generic_Count_Method_Double
{
    public class Box<T> : IComparable<T>
        where T : IComparable<T>
    {
        public Box(T value)
        {
            this.Value = value;
        }

        public T Value { get; private set; }

        public int CompareTo(T other)
        {
            return this.Value.CompareTo(other);
        }

        public override string ToString()
        {
            return $"{this.Value.GetType().FullName}: {this.Value}";
        }
    }
}
