using AutoMapper;
using DatabaseEF.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEF.ExtentionMethods
{
    public static class TodoExtentionMethods
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

        public static List<TodoDTO> ToTodoDTOs(this DbSet<TodoItem> items)
        {
            return Mapper.Map<List<TodoDTO>>(items);
        }

        public static List<TodoItem> ToTodoItems(this IEnumerable<TodoDTO> dtos)
        {
            return Mapper.Map<List<TodoItem>>(dtos);
        }

        public static List<TodoItem> ToTodoItems(this DbSet<TodoDTO> dtos)
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
