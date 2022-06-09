using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Generic_Box_of_String
{
    // Какво се случва
    public class Box<T> // 1.като кажем че входящия тип е инт тогава 
    {
        public Box(T element) // 2.element става/сетва се от тип инт
        {
            this.Element = element; // <- element става инт; 3. Element става Инт 
        }

        public T Element { get; private set; } //4.  Element от инт става публичен  и може да се гетне, сетва се само вътрешно в класа

        //5. Разпечатваме на екрана с името на типа и самия елемент
        public override string ToString()
        {
            return $"{this.Element.GetType().FullName}: {this.Element}";
            // Друг оувъррайд
            // return $"{typeof(T)}: {this.Element}";
        }

    }
}
