namespace Route.ADV01._3_GenericConstraint
{
    internal class Person
    {
        public Person()
        {

        }

        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id{ get; set; }
        public string Name { get; set; }
    }
}
