using Microsoft.EntityFrameworkCore;
using ToDoApi.Models;

namespace ToDoApi.Data
{
    public class TodoDbContext:DbContext
    {
        public TodoDbContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
