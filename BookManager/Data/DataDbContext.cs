
using Microsoft.EntityFrameworkCore;
using BookManager.Models;
namespace BookManager.Data
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           

        }

    }
}

