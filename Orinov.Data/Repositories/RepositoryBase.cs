using Microsoft.EntityFrameworkCore;
using Orinov.Data.Context;
using Orinov.Domain.Interfaces;

namespace Orinov.Data.Repositories
{
    public class RepositoryBase<TEntity> : IGenericInterface<TEntity> where TEntity : class
    {
        protected readonly OrinovDbContext context;

        public RepositoryBase(OrinovDbContext context)
        {
            this.context = context;
        }
        public async Task Add(TEntity entity)
        {
            await context.Set<TEntity>().AddAsync(entity);
        }

        public void Delete(TEntity entity)
        {
            context.Set<TEntity>().Remove(entity);
        }

        public async Task<TEntity> Get(int id)
        {
            return await context.Set<TEntity>().FindAsync(id) ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await context.Set<TEntity>().ToListAsync();
        }

        public void Update(TEntity entity)
        {
            context.Set<TEntity>().Update(entity);
        }
    }
}
