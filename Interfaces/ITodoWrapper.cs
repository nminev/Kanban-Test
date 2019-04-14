using System.Collections.Generic;
using Data.DTOs;
using Data.Enum;

namespace Interfaces
{
    public interface ITodoWrapper : IWrapper<TodoDTO>
    {
        List<TodoDTO> GetItemByState(State state);
    }
}