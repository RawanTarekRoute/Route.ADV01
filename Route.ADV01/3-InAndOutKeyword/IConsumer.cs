namespace Route.ADV01._3_InAndOutKeyword
{
    internal interface IConsumer<in T>
    {
        public void Consume(T animal);
        //public T Print();
    }
}
