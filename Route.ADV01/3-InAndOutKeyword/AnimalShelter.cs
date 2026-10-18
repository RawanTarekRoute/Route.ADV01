namespace Route.ADV01._3_InAndOutKeyword
{
    internal class AnimalShelter : IShelter<Animal>
    {
        public Animal GetAnimal()
        {
            return new Dog("D01");
        }

        public void TreatAnimal(Animal Animal)
        {
            Console.WriteLine("Treating the animal");
        }
    }
}
