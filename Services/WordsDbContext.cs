using Microsoft.EntityFrameworkCore;
using words_api.Models;

namespace words_api.Services
{
    public class WordsDbContext: DbContext
    {
        public DbSet<Word> Words { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=database.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Word>();           
        }
    }
}