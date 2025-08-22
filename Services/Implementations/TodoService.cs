using Entities.Dtos;
using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;

namespace Services.Implementations
{
    public class TodoService : ITodoService
    {
        private readonly IRepositoryManager _manager;

        public TodoService(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public async Task<IEnumerable<Todo>> GetAllTodos(bool trackChanges)
        {
            return await _manager
                .TodoRepository
                .FindAllTodosAsync(trackChanges);
        }
        public async Task<Todo> GetTodoById(int id, bool trackChanges)
        {
            return await _manager
                .TodoRepository
                .FindTodoByIdAsync(id, trackChanges);
        }
        public Todo CreateOneTodo(TodoDto todo)
        {
            var entity = new Todo()
            {
                Title = todo.Title,
                Description = todo.Description
            };
            _manager.TodoRepository
                .CreateTodo(entity);
            return entity;
        }
        public async Task UpdateOneTodo(int id, TodoDto todo, bool trackChanges)
        {
            var entity = await _manager
                .TodoRepository
                .FindTodoByIdAsync(id, true);
        }
        public async Task DeleteOneTodo(int id, bool trackChanges)
        {
            var entity = await _manager
                .TodoRepository
                .FindTodoByIdAsync(id, true);

            _manager
                .TodoRepository
                .DeleteTodo(entity);
        }
    }
}