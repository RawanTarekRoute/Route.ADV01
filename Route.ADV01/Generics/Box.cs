using System;
using System.Collections.Generic;
using System.Text;

namespace Route.ADV01.Generics
{
    // placeholder
    internal class Box<T>
    {
        public Box(T value)
        {
            Value = value;
        }

        public T Value { get; set; }

        public void Print(T value)
        {
            //Console.WriteLine(value + 1);
            Console.WriteLine(value);
        }

        public void PrintOld(object value)
        {
            Console.WriteLine((int) value + 1);
        }

    }
}
