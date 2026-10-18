using System;
using System.Collections.Generic;
using System.Text;

namespace Route.ADV01._3_InAndOutKeyword
{
    internal class CatShelter : IShelter<Cat>
    {
        public void TreatAnimal(Cat Animal)
        {
            Console.WriteLine("Treating cat");
        }
    }
}
