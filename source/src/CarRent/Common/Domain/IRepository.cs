namespace CarRent.Common.Domain
{
    public interface IRepository<TEntity, TId>
    {
        TEntity GetById(TId id);

        void Add(TEntity entity);

        void Remove(TEntity entity);

        void Remove(TId id);
    }
}
