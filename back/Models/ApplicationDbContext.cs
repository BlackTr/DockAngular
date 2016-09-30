using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<TodoItem> Items { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}