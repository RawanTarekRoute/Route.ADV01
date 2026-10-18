using System;
using System.Collections.Generic;
using System.Text;

namespace Route.ADV01._3_InAndOutKeyword
{
    internal class AnimalProducer : IProducer<Animal>
    {
        public void Print(Animal animal)
        {
            throw new NotImplementedException();
        }

        public Animal Produce()
        {
            return new Animal("A01");
        }

    }
}
