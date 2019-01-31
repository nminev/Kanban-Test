using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatabaseEF;
using DatabaseEF.Mapping;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DatabaseEF.DTOs;
using DatabaseEF.Enum;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Kanban.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : Controller
    {
        private readonly KanbanContext _context;
        private TodoWrapper _todoWrapper;
        public TodoController(KanbanContext context,TodoWrapper todoWrapper)
        {
            _todoWrapper = todoWrapper;
            if (_todoWrapper.GetTodoItems().Count()==0)
            {
                _todoWrapper.AddItem(new TodoDTO
                {
                    Name = "Item 1",
                    IsComplete = false,
                    State = State.InQueue
                });
            }
        }

        // GET: api/Todo
        [HttpGet]
        public ActionResult<IEnumerable<TodoDTO>> GetTodoItems()
        {
            return _todoWrapper.GetTodoItems();
        }

        // GET: api/Todo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TodoDTO>> GetTodoItem(int id)
        {
            var todoItem = await _todoWrapper.GetItemByIdAsync(id);

            if (todoItem == null)
            {
                return NotFound();
            }

            return todoItem;
        }

        // POST: api/Todo
        [HttpPost]
        public async Task<ActionResult<TodoDTO>> PostTodoItem(TodoDTO item)
        {
            _todoWrapper.AddItem(item);
            await _todoWrapper.CompleteAsync();

            return CreatedAtAction(nameof(GetTodoItem), new { id = item.ID }, item);
        }

        // PUT: api/Todo/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTodoItem(long id, TodoDTO item)
        {
            if (id != item.ID)
            {
                return BadRequest();
            }
            _todoWrapper.UpdateItem(item);
            await _todoWrapper.CompleteAsync();

            return NoContent();
        }
    }
}
