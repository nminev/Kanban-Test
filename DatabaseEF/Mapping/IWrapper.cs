using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DatabaseEF.DTOs;
using DatabaseEF.Enum;

namespace DatabaseEF.Mapping
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
