using Repositories.Contexts;
using Repositories.Contracts;

namespace Repositories.Implementations
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _context;
        private readonly ITodoRepository _todoRepository;

        public RepositoryManager(RepositoryContext context, ITodoRepository todoRepository)
        {
            _context = context;
            _todoRepository = todoRepository;
        }

        public ITodoRepository TodoRepository => _todoRepository;

        public void SaveAsync()
        {
            _context.SaveChangesAsync();
        }
    }
}
