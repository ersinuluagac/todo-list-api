using System.Linq.Expressions;

namespace Repositories.Contracts
{
    public interface IBaseRepository<T>
    {
        /// <summary>
        /// Get all entities from database.
        /// </summary>
        /// <param name="trackChanges">Should entities be tracked?</param>
        /// <returns>Queryable collection of entities.</returns>
        IQueryable<T> FindAll(bool trackChanges);

        /// <summary>
        /// Get a single entity from the database that matches the condition.
        /// </summary>
        /// <param name="expression">Search condition.</param>
        /// <param name="trackChanges">Should the entity be tracked?</param>
        /// <returns>The matching entity.</returns>
        T FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges);

        /// <summary>
        /// Add a new entity to the database.
        /// </summary>
        /// <param name="entity">Entity to add.</param>
        void Create(T entity);

        /// <summary>
        /// Update an existing entity in the database.
        /// </summary>
        /// <param name="entity">Entity to update.</param>
        void Update(T entity);

        /// <summary>
        /// Remove an entity from the database.
        /// </summary>
        /// <param name="entity">Entity to remove.</param>
        void Delete(T entity);
    }
}
