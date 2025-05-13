using Lab6;
using Microsoft.EntityFrameworkCore;

namespace RecipeApp
{
    public class AppDbContext : DbContext
    {
        public DbSet<Animal> Animals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // 🔧 Підключення до локального SQL Server (можна змінити під ваш)
            optionsBuilder.UseSqlite("Data Source=petshop.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Налаштування моделі (необов'язково, але корисно)
            modelBuilder.Entity<Animal>(entity =>
            {
                entity.HasKey(a => a.Id);
                entity.Property(a => a.Name).IsRequired().HasMaxLength(100);
                entity.Property(a => a.Species).IsRequired().HasMaxLength(50);
                entity.Property(a => a.Price).HasColumnType("decimal(10,2)");
                entity.Property(a => a.Stock).IsRequired();
            });
        }
    }
}
