using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public partial class ToDoListDbContext : DbContext
    {
    }

    public ToDoListDbContext()
    {
    }

    public ToDoListDbContext(DbContextOptions<ToDoListDbContext> options) : base(options);

    public virtual DbSet<ToDo> ToDos { get; set; }


}
