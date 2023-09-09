using CTC.Shared.IRepository;
using Microsoft.EntityFrameworkCore;

namespace CTC.Shared.Repository
{
    public abstract class QueryRepository<TEntity> : object, IQueryRepository<TEntity> where TEntity : BaseEntitys.Abstracts.EntityID
    {
        protected QueryRepository
            (DbContext? databaseContext) : base()
        {
            DatabaseContext =
                databaseContext ??
                throw new ArgumentNullException(paramName: nameof(databaseContext));

            DbSet = DatabaseContext.Set<TEntity>();
        }

        protected DbSet<TEntity> DbSet { get; }
        protected DbContext DatabaseContext { get; }

        public virtual async Task<TEntity> GetByIdAsync(string? id)
        {
            return await DbSet.FindAsync(keyValues: id);
        }
        public virtual async Task<IList<TEntity>> GetAllAsync()
        {
            var result =
                await
                DbSet.ToListAsync();

            return result;
        }
        public async Task<TEntity> GetAsync(TEntity? model)
        {
            return await DbSet.FindAsync(model.ID);
        }
    }
}
