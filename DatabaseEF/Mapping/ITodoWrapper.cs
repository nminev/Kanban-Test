using DatabaseEF.DTOs;
using DatabaseEF.Enum;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DatabaseEF.Mapping
{
    public interface ITodoWrapper:IWrapper<TodoDTO>
    {
        List<TodoDTO> GetItemByState(State state);

    }
}