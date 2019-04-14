using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IWrapper<TEntity> where TEntity : class
    {
        TEntity GetItemById(int id);
        List<TEntity> GetTodoItems();

        void UpdateItem(TEntity dtoItem);
        void DeleteItem(int id);
        void AddItem(TEntity dtoItem);
        int Complete();
        Task<TEntity> GetItemByIdAsync(int id);
        Task<int> CompleteAsync();
    }
}