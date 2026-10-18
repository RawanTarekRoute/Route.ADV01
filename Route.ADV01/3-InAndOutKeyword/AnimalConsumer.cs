using System;
using System.Collections.Generic;
using System.Text;

namespace Route.ADV01._3_InAndOutKeyword
{
    internal class AnimalConsumer : IConsumer<Animal>
    {
        public void Consume(Animal animal)
        {
            Console.WriteLine("Consuming Animal");

        }

        public Animal Print()
        {
            return new Animal("A01");
        }
    }
}
