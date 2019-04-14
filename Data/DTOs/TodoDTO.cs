using System.Runtime.Serialization;
using Data.Enum;

namespace Data.DTOs
{
    [DataContract]
    public class TodoDTO
    {
        [DataMember] public int ID { get; set; }

        [DataMember] public string Name { get; set; }

        [DataMember] public State State { get; set; }

        [DataMember] public int PersonOnItID { get; set; }
    }
}