using Microsoft.Data.Entity;
using System;

namespace TodoList.Models
{
    public class TodoDbContext : DbContext
    {
        public DbSet<TodoItem> TodoItems { get; set; }

        protected override void OnConfiguring(DbContextOptions options)
        {
            // Workaround bug in EF, connection string is not flowing through from config.json
            // options.UseSqlServer();
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=TodoList01;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

    }
}