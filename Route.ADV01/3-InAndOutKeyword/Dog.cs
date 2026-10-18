namespace Route.ADV01._3_InAndOutKeyword
{
    internal class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
        }

        public override void Speak()
        {
            Console.WriteLine("Cat is speaking");
        }
    }
}
