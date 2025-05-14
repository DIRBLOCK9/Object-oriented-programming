using Lab7.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Windows.UI;

namespace Lab7.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Animal> Animals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=animals.db");
        }
    }
}
