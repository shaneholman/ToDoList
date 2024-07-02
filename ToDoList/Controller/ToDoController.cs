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
        
        public static List<ToDo> GetAllToDos()
        {
            return _context.ToDos.ToList();
        }

        public static void AddToDoItem(ToDo todo)
        {
            var _context = new ToDoListDbContext();
            _context.ToDos.Add(todo);
            _context.SaveChanges();

        }
        public static void UpdateToDoItem()
        {
            var _context = new ToDoListDbContext();

        }
    
    }
   
}
