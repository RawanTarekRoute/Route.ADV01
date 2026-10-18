namespace Route.ADV01._2_GenericInterfaces
{
    // use class to implement the interface => define what T means
    internal interface IRepository<TEntity>
    {
        void Create(TEntity entity);
        void Update(int id, TEntity entity);
        List<TEntity> GetAll();

        TEntity GetById(int id);
        void Delete(int id);
    }
}
