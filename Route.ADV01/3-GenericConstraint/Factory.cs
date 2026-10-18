namespace Route.ADV01._3_GenericConstraint
{
    internal class Factory<T> where T: class, new() 
    {
        public T Create()
        {
            return new T();
        }
    }
}
