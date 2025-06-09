using Microsoft.EntityFrameworkCore;

namespace WebApiApp02.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected AppDbContext()
        {
        }

        // 제일 중요
        public DbSet<Book> Book { get; set; }
    }
}
