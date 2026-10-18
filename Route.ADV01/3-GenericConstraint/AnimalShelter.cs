using System;
using System.Collections.Generic;
using System.Text;

namespace Route.ADV01._3_GenericConstraint
{
    internal class AnimalShelter<T> where T : Animal
    {
        private List<T> animals = [];

        public void Add(T Animal)
        {
            animals.Add(Animal);
        }


        public void Display()
        {
            foreach(T Animal in animals)
            {
                Console.WriteLine($"{Animal.Name}");
            }
        }
    }
}
