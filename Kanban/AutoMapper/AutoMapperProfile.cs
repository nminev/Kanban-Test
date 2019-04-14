using AutoMapper;
using Data.DTOs;
using Data.Models;

namespace Kanban.AutoMapper
{
    internal class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            //CreateMap<TodoItem, TodoDTO>();
            //CreateMap<TodoDTO, TodoItem>();
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<TodoDTO, TodoItem>();
                cfg.CreateMap<TodoItem, TodoDTO>();
            });
        }
    }
}