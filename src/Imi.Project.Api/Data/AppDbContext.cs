using Imi.Project.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Imi.Project.Api.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<UnitsOfMeasure> UnitsOfMeasure { get; set; }
        public DbSet<Ingedrients> Ingedrients { get; set; }
        public DbSet<Recipes> Recipes { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
}
