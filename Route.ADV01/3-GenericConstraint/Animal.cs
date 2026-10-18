namespace Route.ADV01._3_GenericConstraint
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
