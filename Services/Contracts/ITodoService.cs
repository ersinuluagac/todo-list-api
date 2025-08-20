using Entities.Dtos;
using Entities.Models;

namespace Services.Contracts
{
    public interface ITodoService
    {
        IEnumerable<Todo> GetAllTodos(bool trackChanges);
        Todo GetTodoById(int id, bool trackChanges);
        Todo CreateOneTodo(TodoDto todo);
        void UpdateOneTodo(int id, TodoDto todo, bool trackChanges);
        void DeleteOneTodo(int id, bool trackChanges);
    }
}
