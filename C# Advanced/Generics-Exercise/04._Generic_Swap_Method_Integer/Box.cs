﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Generic_Swap_Method_Integer
{
    public class Box<T>
    {
        public Box(T value)
        {
            this.Value = value;
        }

        public T Value { get; private set; }

        public override string ToString()
        {
            return $"{this.Value.GetType().FullName}: {this.Value}";
        }
    }
}
