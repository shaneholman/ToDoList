using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    internal class ToDo{

        [StringLength(80)]
        public string Description { get; set; } = string.Empty;

        public DateTime DueDate { get; set; } = new DateTime();

        [StringLength(30)]
        public string Status { get; set; } = "Active";

        [StringLength(30)]
        public string Priority { get; set; } = string.Empty;
    }
}
