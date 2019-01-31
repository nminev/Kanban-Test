using AutoMapper;
using DatabaseEF.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace DatabaseEF.Mapping
{
    public class TodoWrapper
    {
        KanbanContext _context;
        public TodoWrapper()
        {
            _context = new KanbanContext(null);
        }


        public TodoDTO GetItemById(int id)
        {
            var todoItem = FindContextItem(id);
            return Mapper.Map<TodoDTO>(todoItem);
        }
        public List<TodoDTO> GetTodoItems()
        {
            var todoItems = _context.TodoItems;
            return Mapper.Map<List<TodoDTO>>(todoItems);
        }

        public void UpdateItem(TodoDTO dtoItem)
        {
            var todoItem = FindContextItem(dtoItem.ID);
            Mapper.Map(dtoItem, todoItem);
            Complete();
        }
        public void DeleteItem(int id)
        {
            var todoItem = FindContextItem(id);
            _context.TodoItems.Remove(todoItem);
        }
        public void AddItem(TodoDTO dtoItem)
        {
            _context.Add(dtoItem);
        }
        public int Complete()
        {
            return _context.SaveChanges();
        }

        private TodoItem FindContextItem(int id)
        {
            return _context.TodoItems.Find(id);
        }

        #region async actions
        public Task<TodoDTO> GetItemByIdAsync(int id)
        {
            var todoItem = FindContextItemAsync(id);
            return Mapper.Map<Task<TodoDTO>>(todoItem);
        }
        public Task<int> CompleteAsync()
        {
            return _context.SaveChangesAsync();
        }
        private Task<TodoItem> FindContextItemAsync(int id)
        {
            return _context.TodoItems.FindAsync(id);
        }
        #endregion
    }
}
