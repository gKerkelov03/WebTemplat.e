namespace Template.Data.Common;

using System;
using System.Linq;
using System.Threading.Tasks;

public interface IEFRepository<TEntity> : IDisposable
    where TEntity : class
{
    IQueryable<TEntity> All();

    IQueryable<TEntity> AllAsNoTracking();

    Task AddAsync(TEntity entity);

    void Update(TEntity entity);

    void Delete(TEntity entity);

    Task<int> SaveChangesAsync();
}
