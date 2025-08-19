using Microsoft.EntityFrameworkCore;
using Repositories.Contexts;
using Repositories.Contracts;
using System.Linq.Expressions;

namespace Repositories.Implementations
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, new()
    {
        // Dependency Injection
        protected readonly RepositoryContext _context;

        // Constructor
        protected BaseRepository(RepositoryContext context)
        {
            _context = context;
        }

        //  CRUD operations
        public IEnumerable<T> FindAll(bool trackChanges)
        {
            return trackChanges
                ? _context.Set<T>()
                : _context.Set<T>().AsNoTracking();
        }
        public T FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges)
        {
            return trackChanges
                ? _context.Set<T>().Where(expression).SingleOrDefault()
                : _context.Set<T>().Where(expression).AsNoTracking().SingleOrDefault();
        }
        public void Create(T entity)
        {
            _context.Set<T>().Add(entity);
        }
        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }
    }
}
