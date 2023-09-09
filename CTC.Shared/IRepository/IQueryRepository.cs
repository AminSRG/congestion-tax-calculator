using CTC.Shared.BaseEntitys.Abstracts;

namespace CTC.Shared.IRepository
{
    public interface IQueryRepository<T> where T : BaseEntity
    {
        Task<T> GetAsync(T model);
        Task<T> GetByIdAsync(string id);
        Task<IList<T>> GetAllAsync();
    }
}
