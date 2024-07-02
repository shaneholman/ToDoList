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
       public static ToDoListDbContext _context = new ToDoListDbContext();
        public static List<ToDo> getalltodos()
        {
            return _context.ToDos.ToList();
        }

        public static void AddToDoItem(ToDo todo)
        {
            var _context = new ToDoListDbContext();
            var defaultDueDate = DateTime.Today;
            var ans = Convert.ToInt32(Console.ReadLine());
            var toDoDescription = ans; 
            
         
        }
        public static void UpdateToDoItem()
        {
            var _context = new ToDoListDbContext();

        }
    
    }
   
}
