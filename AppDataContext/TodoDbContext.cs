using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using TodoAPI.Models;

namespace TodoAPI.AppDataContext {
    public class TodoDbContext : DbContext {
        private readonly DbSettings _dbSettings;

        public TodoDbContext(IOptions<DbSettings> dbSettings) {
            _dbSettings = dbSettings.Value;
        }

        public DbSet<Todo> Todos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todo>().ToTable("TodoAPI").HasKey(t => t.Id);
        }
    }
}