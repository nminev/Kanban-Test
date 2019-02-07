using AutoMapper;
using DatabaseEF;
using DatabaseEF.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kanban.AutoMapper
{
    class AutoMapperProfile:Profile
    {
        
        public AutoMapperProfile()
        {
            //CreateMap<TodoItem, TodoDTO>();
            //CreateMap<TodoDTO, TodoItem>();
            Mapper.Initialize(cfg => {
                cfg.CreateMap<TodoDTO, TodoItem>();
                cfg.CreateMap<TodoItem, TodoDTO>();
            });

        }
    }
}
