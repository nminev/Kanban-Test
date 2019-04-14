using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Data.Enum;

namespace Data.Models
{
    public class TodoItem
    {
        [Key] public int ID { get; set; }

        public string Name { get; set; }

        public virtual Person PersonOnIt { get; set; }

        public State State { get; set; }

        [ForeignKey("PersonOnIt")] public int? PersonOnItID { get; set; }
    }
}