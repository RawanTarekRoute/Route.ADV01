namespace Route.ADV01._3_InAndOutKeyword
{
    internal interface IProducer<out T>
    {
        T Produce();

        //void Print(T animal);
    }
}
