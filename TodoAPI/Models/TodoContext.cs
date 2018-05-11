using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TodoAPI.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TodoContext>();
            optionsBuilder.UseSqlServer("Data Source=TodoDB.db");

            using (var context = new TodoContext(optionsBuilder.Options))
            {
                // do stuff
            }
        }

        public DbSet<TodoItem> TodoItems { get; set; }

    }
}