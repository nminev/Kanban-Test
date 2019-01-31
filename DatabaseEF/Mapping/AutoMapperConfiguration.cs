using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseEF.DTOs
{
    class AutoMapperConfiguration:Profile
    {
        
        public AutoMapperConfiguration()
        {
            CreateMap<TodoItem, TodoDTO>();
        }
    }
}
