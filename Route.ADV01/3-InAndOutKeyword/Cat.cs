namespace Route.ADV01._3_InAndOutKeyword
{
    internal class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
        }

        public override void Speak()
        {
            Console.WriteLine("Cat is speaking");
        }
    }
}
