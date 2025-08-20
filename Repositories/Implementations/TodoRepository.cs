using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Contexts;
using Repositories.Contracts;

namespace Repositories.Implementations
{
    public class TodoRepository : BaseRepository<Todo>, ITodoRepository
    {
        // Constructor
        public TodoRepository(RepositoryContext context) : base(context)
        {
            // The context is passed to the BaseRepository constructor.
        }

        // CRUD operations for Todo entity
        public async Task<IEnumerable<Todo>> FindAllTodosAsync(bool trackChanges)
        {
            return await FindAll(trackChanges)
                .OrderBy(t => t.Id)
                .ToListAsync();
        }
        public async Task<Todo?> FindTodoByIdAsync(int id, bool trackChanges)
        {
            return await FindByCondition(t => t.Id.Equals(id), trackChanges)
                .SingleOrDefaultAsync();
        }
        public void CreateTodo(Todo todo)
        {
            Create(todo);
        }
        public void UpdateTodo(Todo todo)
        {
            Update(todo);
        }
        public void DeleteTodo(Todo todo)
        {
            Delete(todo);
        }
    }
}