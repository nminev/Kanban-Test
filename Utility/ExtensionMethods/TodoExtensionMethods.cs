using AutoMapper;
using Data.DTOs;
using Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// ReSharper disable InconsistentNaming

namespace Utility.ExtensionMethods
{
    public static class TodoExtensionMethods
    {
        public static TodoItem ToTodoItem(this TodoDTO dto)
        {
            return Mapper.Map<TodoItem>(dto);
        }

        public static Task<TodoItem> ToTodoItem(this Task<TodoDTO> dto)
        {
            return Mapper.Map<Task<TodoItem>>(dto);
        }

        public static TodoDTO ToTodoDTO(this TodoItem item)
        {
            return Mapper.Map<TodoDTO>(item);
        }

        public static Task<TodoDTO> ToTodoDTO(this Task<TodoItem> item)
        {
            return Mapper.Map<Task<TodoDTO>>(item);
        }

        public static List<TodoDTO> ToTodoDTOs(this IEnumerable<TodoItem> items)
        {
            return Mapper.Map<List<TodoDTO>>(items);
        }

        public static List<TodoDTO> ToTodoDTOs(this IQueryable<TodoItem> items)
        {
            return Mapper.Map<List<TodoDTO>>(items);
        }

        public static List<TodoItem> ToTodoItems(this IEnumerable<TodoDTO> dtos)
        {
            return Mapper.Map<List<TodoItem>>(dtos);
        }

        public static List<TodoItem> ToTodoItems(this IQueryable<TodoDTO> dtos)
        {
            return Mapper.Map<List<TodoItem>>(dtos);
        }

        public static TodoItem UpdateTodoItem(this TodoItem item, TodoDTO dto)
        {
            return Mapper.Map(dto, item);
        }

        public static TodoDTO UpdateTodoDTO(this TodoDTO dto, TodoItem item)
        {
            return Mapper.Map(item, dto);
        }
    }
}