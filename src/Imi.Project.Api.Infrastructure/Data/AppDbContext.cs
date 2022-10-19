using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Infrastructure.Data.Seeding;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Imi.Project.Api.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<UnitOfMeasure> UnitsOfMeasure { get; set; }
        public DbSet<Ingedrient> Ingedrients { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<RecipeIngedrient> RecipeIngedrients { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            UnitOfMeasureSeeder.Seed(modelBuilder);
            IngedrientSeeder.Seed(modelBuilder);
            RecipeSeeder.Seed(modelBuilder);
            UserSeeder.Seed(modelBuilder);

            modelBuilder.Entity<RecipeIngedrient>()
                .HasKey(ri => new { ri.RecipeId, ri.IngedrientId });

            modelBuilder.Entity<RecipeIngedrient>()
                .HasOne(ri => ri.Recipe)
                .WithMany(r => r.ListOfIngedrients)
                .HasForeignKey(ri => ri.RecipeId);

            modelBuilder.Entity<RecipeIngedrient>()
                .HasOne(ri => ri.Ingedrient)
                .WithMany(i => i.UsedInRecipes)
                .HasForeignKey(ri => ri.IngedrientId);
        }
    }
}
