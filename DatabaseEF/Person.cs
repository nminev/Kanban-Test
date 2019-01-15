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

        public Task Task { get; set; }

        [ForeignKey("Task")]
        public int TaskID { get; set; }

    }
}
