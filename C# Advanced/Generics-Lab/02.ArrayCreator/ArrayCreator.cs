﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _02.ArrayCreator
{
    public class ArrayCreator
    {
        public static T[] Create<T>(int length, T value)
        {
            var array = new T[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = value;
            }

            return array;
        }
    }
}
