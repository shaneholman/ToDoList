using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Controller
{
    internal class ToDoController
    {
        

        static void AddToDoItem()
        {
            var _context = new ToDoListDbContext();
            var defaultDueDate = DateTime.Today;


            var newToDo = new ToDo
            {
                Id = 0,
                Description = "",
                DueDate = defaultDueDate,
                Status = "Active",
                Priority = "Medium"
            };
        }
    }
   
}
