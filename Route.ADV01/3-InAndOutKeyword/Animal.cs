using System;
using System.Collections.Generic;
using System.Text;

namespace Route.ADV01._3_InAndOutKeyword
{
    internal class Animal
    {
        public Animal(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        
        public virtual void Speak()
        {
            Console.WriteLine("Animal is speaking");
        }
    }
}
