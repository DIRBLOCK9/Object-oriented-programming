using Microsoft.EntityFrameworkCore;
using Lab6; // змінити, якщо твоя модель не в цій папці

namespace Lab6.Data
{
    public class PetShopContext : DbContext
    {
        public DbSet<Animal> Animals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=petshop.db");
        }
    }
}
