using Bulky.DataAccess.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Bulky.DataAccess.Repository.Implementations;
public class Repository<T>(ApplicationDbContext context) : IRepository<T> where T : class
{
    internal DbSet<T> _dbSet = context.Set<T>();

   public void Add(T entity)
    {
        _dbSet.Add(entity);
    }

    public T Get(Expression<Func<T, bool>> filter)
    {
        IQueryable<T> query = _dbSet.AsQueryable();
        query = query.Where(filter);
        return query.FirstOrDefault();
    }

    public IEnumerable<T> GetAll()
    {
        IQueryable<T> query = _dbSet.AsQueryable();
        return query.ToList();
    }

   public void Remove(T entity)
    {
        _dbSet.Remove(entity);
    }

    public void RemoveRange(IEnumerable<T> entities)
    {
        _dbSet.RemoveRange(entities);
    }
}
