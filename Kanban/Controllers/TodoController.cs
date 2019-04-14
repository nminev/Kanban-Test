﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Data.DTOs;
using Data.Enum;
using DatabaseEF;
using Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Kanban.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : Controller
    {
        private readonly ITodoWrapper _todoWrapper;

        public TodoController(KanbanContext context, ITodoWrapper todoWrapper)
        {
            _todoWrapper = todoWrapper;
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

            if (todoItem == null) return NotFound();

            return todoItem;
        }

        // POST: api/Todo
        [HttpPost]
        public async Task<ActionResult<TodoDTO>> PostTodoItem(TodoDTO item)
        {
            _todoWrapper.AddItem(item);
            await _todoWrapper.CompleteAsync();

            return CreatedAtAction(nameof(GetTodoItem), new {id = item.ID}, item);
        }

        // PUT: api/Todo/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTodoItem(long id, TodoDTO item)
        {
            if (id != item.ID) return BadRequest();
            _todoWrapper.UpdateItem(item);
            await _todoWrapper.CompleteAsync();

            return NoContent();
        }

        //DELETE: api/Todo/5 
        [HttpDelete("{id}")]
        public async Task<IActionResult> PutTodoItem(int id)
        {
            try
            {
                _todoWrapper.DeleteItem(id);
                await _todoWrapper.CompleteAsync();
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        // GET: api/Todo/InQueue
        [HttpGet]
        [Route("state/{requestedState}")]
        public ActionResult<List<TodoDTO>> GetTodoItemInState(string requestedState)
        {
            State state;
            if (!Enum.TryParse(requestedState, out state)) return BadRequest();
            var todoItems = _todoWrapper.GetItemByState(state);

            return Ok(todoItems);
        }
    }
}