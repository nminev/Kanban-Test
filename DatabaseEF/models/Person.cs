using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DatabaseEF
{
    public class Person
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        public virtual TodoItem TodoItem { get; set; }

        [ForeignKey("TodoItem")]
        public int? TodoItemID { get; set; }

    }
}
