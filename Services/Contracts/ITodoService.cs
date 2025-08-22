using Entities.Dtos;
using Entities.Models;

namespace Services.Contracts
{
    public interface ITodoService
    {
        Task<IEnumerable<Todo>> GetAllTodos(bool trackChanges);
        Task<Todo> GetTodoById(int id, bool trackChanges);
        Todo CreateOneTodo(TodoDto todo);
        Task UpdateOneTodo(int id, TodoDto todo, bool trackChanges);
        Task DeleteOneTodo(int id, bool trackChanges);
    }
}
