using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{
    public class Person
    {
        [Key] public int ID { get; set; }

        public string Name { get; set; }

        public virtual TodoItem TodoItem { get; set; }

        [ForeignKey("TodoItem")] public int? TodoItemID { get; set; }
    }
}