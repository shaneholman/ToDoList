using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Controller
{
    public class ToDoController
    {
        

        static void AddToDoItem()
        {
            var _context = new ToDoListDbContext();
            var defaultDueDate = DateTime.Today;
            var ans = Convert.ToInt32(Console.ReadLine());
            var toDoDescription = ans; 
            
            var newToDo = new ToDo
            {
                Id = 0,
                Description = $"{toDoDescription}",
                DueDate = defaultDueDate,
                Status = "Active",
                Priority = "Medium"
            };
        }
        static void UpdateToDoItem()
        {
            var _context = new ToDoListDbContext();

        }
    
    }
   
}
