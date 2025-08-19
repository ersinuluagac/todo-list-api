using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Contexts;
using Repositories.Contracts;

namespace Repositories.Implementations
{
    public class TodoRepository : BaseRepository<Todo>, ITodoRepository
    {
        public TodoRepository(RepositoryContext context) : base(context)
        {
            // The context is passed to the BaseRepository constructor.
        }

        // CRUD operations for Todo items
        public async Task<IEnumerable<Todo>> FindAllTodosAsync(bool trackChanges)
        {
            return await FindAll(trackChanges)
                .OrderBy(t => t.Id)
                .ToListAsync();
        }
        public Task<Todo> FindTodoByIdAsync(int id, bool trackChanges)
        {
            throw new NotImplementedException();
        }
        public void CreateTodo(Todo todo)
        {
            throw new NotImplementedException();
        }
        public void UpdateTodo(Todo todo)
        {
            throw new NotImplementedException();
        }
        public void DeleteTodo(int id)
        {
            throw new NotImplementedException();
        }
    }
}
