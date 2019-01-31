using DatabaseEF.Enum;
using System.Runtime.Serialization;

namespace DatabaseEF.DTOs
{
    [DataContract]
    public class TodoDTO
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public bool IsComplete { get; set; }

        [DataMember]
        public State State { get; set; }

        [DataMember]
        public int PersonOnItID { get; set; }

    }
}
