using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TesteLar.Domain.Entities.Base;
using TesteLar.Domain.Interfaces.Base;
using TesteLar.Infra.Context;

namespace TesteLar.Infra.Repository.Base;
public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
{
    protected readonly LarContext _larContext;
    protected readonly DbSet<TEntity> _dbSet;

    protected Repository(LarContext larContext)
    {
        _larContext = larContext;
        _dbSet = larContext.Set<TEntity>();
    }

    public async Task<IList<TEntity>> GetAllAsync()
    {
        return await _dbSet.Where(e => !e.IsDeleted).ToListAsync();
    }

    public async Task<TEntity> GetByIdAsync(int id, params Expression<Func<TEntity, object>>[] includes)
    {
        IQueryable<TEntity> query = _dbSet;

        foreach (var include in includes)
        {
            query = query.Include(include);
        }

        var entity = await query.FirstOrDefaultAsync(e => e.Id == id && !e.IsDeleted);

        return entity ?? throw new KeyNotFoundException($"Entity with id {id} not found.");
    }

    public async Task AddAsync(TEntity entity)
    {
        _dbSet.Add(entity);
        await _larContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(TEntity entity)
    {
        _dbSet.Update(entity);
        await _larContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        TEntity entity = await GetByIdAsync(id);
        entity.IsDeleted = true;
        await UpdateAsync(entity);
        await _larContext.SaveChangesAsync();
    }

    public void Dispose()
    {
        _larContext?.Dispose();
    }
}
