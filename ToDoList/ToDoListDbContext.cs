using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Controller;

namespace ToDoList
{
    public partial class ToDoListDbContext : DbContext
    {


        public ToDoListDbContext()
        {
        }

        public ToDoListDbContext(DbContextOptions<ToDoListDbContext> options) : base(options)
        {

        }

        public virtual DbSet<ToDo> ToDos { get; set; }
        public virtual DbSet<ToDoController> ToDosController { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("server=localhost\\sqlexpress01;database=ToDoListDb;trusted_connection=true;trustServerCertificate=true;");
    }
}
