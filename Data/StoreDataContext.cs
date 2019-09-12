using Microsoft.EntityFrameworkCore;
using APIS.Models;
using APIS.Data.Maps;

namespace APIS.Data
{
    public class StoreDataContext : DbContext
    {
        public DbSet<Product> Products {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ProductMap());
        }

    }
}