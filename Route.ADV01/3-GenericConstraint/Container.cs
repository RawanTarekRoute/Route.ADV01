namespace Route.ADV01._3_GenericConstraint
{
    internal class Container<T>
    {
        public Container(T value)
        {
            Value = value;
        }

        public T Value { get; set; }
    }
}
