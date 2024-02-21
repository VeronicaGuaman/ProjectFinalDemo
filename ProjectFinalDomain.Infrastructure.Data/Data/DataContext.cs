using Microsoft.EntityFrameworkCore;
using ProjectFinalDemo.Domain.Entities;

namespace ProjectFinalDomain.Infrastructure.Data.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
    }
}
