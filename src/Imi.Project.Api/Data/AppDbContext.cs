using Imi.Project.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Imi.Project.Api.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UnitOfMeasure> UnitsOfMeasure { get; set; }
        public DbSet<Ingedrient> Ingedrients { get; set; }
        public DbSet<Recipe> Recipes { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


        }
    }
}
