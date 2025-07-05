using System.Linq.Expressions;
using TesteLar.Domain.Entities.Base;

namespace TesteLar.Domain.Interfaces.Base
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity
    {
        Task<IList<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(int id, params Expression<Func<TEntity, object>>[] includes);
        Task AddAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(int id);
    }
}
