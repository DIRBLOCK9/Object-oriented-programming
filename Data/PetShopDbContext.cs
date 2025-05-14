using lab_9.Models;
using Microsoft.EntityFrameworkCore;

namespace lab_9.Data
{
    public class PetShopDbContext : DbContext
    {
        public PetShopDbContext(DbContextOptions<PetShopDbContext> options)
            : base(options)
        {
        }

        public DbSet<Animal> Animals { get; set; }
        public DbSet<Species> Species { get; set; }
    }
}