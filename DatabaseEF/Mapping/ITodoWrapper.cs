using DatabaseEF.DTOs;
using DatabaseEF.Enum;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DatabaseEF.Mapping
{
    public interface ITodoWrapper
    {
        TodoDTO GetItemById(int id);
        List<TodoDTO> GetItemByState(State state);
        List<TodoDTO> GetTodoItems();

        void UpdateItem(TodoDTO dtoItem);
        void DeleteItem(int id);
        void AddItem(TodoDTO dtoItem);
        int Complete();


        #region async actions
        Task<TodoDTO> GetItemByIdAsync(int id);
        Task<int> CompleteAsync();
        #endregion
    }
}