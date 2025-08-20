using Entities.Models;

namespace Repositories.Contracts
{
    public interface ITodoRepository
    {
        /// <summary>
        /// Get all Todo items from database.
        /// </summary>
        /// <param name="trackChanges">Should entities be tracked?</param>
        /// <returns>Enumerable collection of entities.</returns>
        Task<IEnumerable<Todo>> FindAllTodosAsync(bool trackChanges);

        /// <summary>
        /// Get a single Todo item from database that matches the condition.
        /// </summary>
        /// <param name="id">The unique identifier of the Todo item.</param>
        /// <param name="trackChanges">Should the entity be tracked?</param>
        /// <returns>The matching Todo item.</returns>
        Task<Todo?> FindTodoByIdAsync(int id, bool trackChanges);

        /// <summary>
        /// Add a new Todo item to the database.
        /// </summary>
        /// <param name="todo">Todo to add.</param>
        void CreateTodo(Todo todo);

        /// <summary>
        /// Update an existing Todo item in the database.
        /// </summary>
        /// <param name="todo">Todo to update.</param>
        void UpdateTodo(Todo todo);

        /// <summary>
        /// Remove an Todo item from the database.
        /// </summary>
        /// <param name="id">Todo to remove</param>
        void DeleteTodo(Todo todo);
    }
}
