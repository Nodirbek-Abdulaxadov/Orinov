namespace Orinov.Domain.Interfaces
{
    public interface IGenericInterface<TEntity> where TEntity : class
    {
        Task<TEntity> Get(int id);
        Task<IEnumerable<TEntity>> GetAll();
        Task Add(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
    }
}
