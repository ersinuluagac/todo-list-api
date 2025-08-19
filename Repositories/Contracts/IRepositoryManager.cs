namespace Repositories.Contracts
{
    public interface IRepositoryManager
    {
        // Classes to manage.
        public ITodoRepository TodoRepository { get; }

        /// <summary>
        /// Saves tracked changes to the database.
        /// </summary>
        void SaveAsync();
    }
}
