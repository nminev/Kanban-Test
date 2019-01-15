using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DatabaseEF
{
    public class Task
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        public Person PersonOnIt { get; set; }

        [ForeignKey("PersonOnIt")]
        public int PersonOnItID { get; set; }

    }
}
