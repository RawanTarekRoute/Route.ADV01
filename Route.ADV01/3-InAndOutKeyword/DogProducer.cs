using System;
using System.Collections.Generic;
using System.Text;

namespace Route.ADV01._3_InAndOutKeyword
{
    internal class DogProducer : IProducer<Dog>
    {
        public Dog Produce()
        {
            return new Dog("D01");
        }

    }
}
