using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.DTOs;
using Data.Enum;
using Data.Models;
using Interfaces;
using Utility.ExtensionMethods;

namespace DatabaseEF.Mapping
{
    public class TodoWrapper : ITodoWrapper
    {
        private readonly KanbanContext _context;

        public TodoWrapper(KanbanContext context)
        {
            _context = context;
        }


        public TodoDTO GetItemById(int id)
        {
            return FindContextItem(id).ToTodoDTO();
        }

        public List<TodoDTO> GetTodoItems()
        {
            return _context.TodoItems.ToTodoDTOs();
        }

        public void UpdateItem(TodoDTO dtoItem)
        {
            FindContextItem(dtoItem.ID).UpdateTodoItem(dtoItem);
            Complete();
        }

        public void DeleteItem(int id)
        {
            var todoItem = FindContextItem(id);
            _context.TodoItems.Remove(todoItem);
        }

        public void AddItem(TodoDTO dtoItem)
        {
            _context.Add(dtoItem.ToTodoItem());
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public List<TodoDTO> GetItemByState(State state)
        {
            return _context.TodoItems.Where(x => x.State == state).ToTodoDTOs();
        }

        private TodoItem FindContextItem(int id)
        {
            return _context.TodoItems.Find(id);
        }

        #region async actions

        public Task<TodoDTO> GetItemByIdAsync(int id)
        {
            return FindContextItemAsync(id).ToTodoDTO();
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