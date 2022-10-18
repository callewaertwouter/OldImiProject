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

            modelBuilder
                .Entity<Recipe>()
                .HasMany(r => r.ListOfIngedrients)
                .WithMany(i => i.UsedInRecipes)
                .UsingEntity<Dictionary<string, object>>("RecipeIngedrients",
                        r => r.HasOne<Ingedrient>().WithMany().HasForeignKey("IngedrientId"),
                        i => i.HasOne<Recipe>().WithMany().HasForeignKey("RecipeId"),
                        ri =>
                        {
                            ri.HasKey("RecipeId, IngedrientId");
                            ri.HasData(
                                new[]
                                {
                                    // Testrecept heeft enkel melk om dit te testen
                                    new { RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000001"), IngedrientId = Guid.Parse("00000000-0000-0000-0000-000000000001")},
                                    // Witte saus heeft boter en melk
                                    new { RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000002"), IngedrientId = Guid.Parse("00000000-0000-0000-0000-000000000005")},
                                    new { RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000002"), IngedrientId = Guid.Parse("00000000-0000-0000-0000-000000000001")},
                                    // Gemarineerde brochetten heeft boter, paprika, ajuin en gehakt
                                    new { RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000003"), IngedrientId = Guid.Parse("00000000-0000-0000-0000-000000000005")},
                                    new { RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000003"), IngedrientId = Guid.Parse("00000000-0000-0000-0000-000000000006")},
                                    new { RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000003"), IngedrientId = Guid.Parse("00000000-0000-0000-0000-000000000008")},
                                    new { RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000003"), IngedrientId = Guid.Parse("00000000-0000-0000-0000-000000000003")},
                                    // Champignonsoep heeft champignons en olijfolie
                                    new { RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000004"), IngedrientId = Guid.Parse("00000000-0000-0000-0000-000000000011")},
                                    new { RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000004"), IngedrientId = Guid.Parse("00000000-0000-0000-0000-000000000010")},
                                    // Gehaktbrood heeft boter, gehakt en ajuin
                                    new { RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000005"), IngedrientId = Guid.Parse("00000000-0000-0000-0000-000000000005")},
                                    new { RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000005"), IngedrientId = Guid.Parse("00000000-0000-0000-0000-000000000003")},
                                    new { RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000005"), IngedrientId = Guid.Parse("00000000-0000-0000-0000-000000000008")},
                                    // Hamburger heeft gehakt en wortel
                                    new { RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000006"), IngedrientId = Guid.Parse("00000000-0000-0000-0000-000000000003")},
                                    new { RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000006"), IngedrientId = Guid.Parse("00000000-0000-0000-0000-000000000007")},
                                    // Viskroketjes met patatten heeft enkel olijfolie
                                    new { RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000007"), IngedrientId = Guid.Parse("00000000-0000-0000-0000-000000000010")},
                                    // Grillworst met puree heeft boter, melk en gehakt
                                    new { RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000008"), IngedrientId = Guid.Parse("00000000-0000-0000-0000-000000000005")},
                                    new { RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000008"), IngedrientId = Guid.Parse("00000000-0000-0000-0000-000000000001")},
                                    new { RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000008"), IngedrientId = Guid.Parse("00000000-0000-0000-0000-000000000003")},
                                    // Spaghetti bolognaise heeft boter, gehakt, wortel, courgette, paprika, ajuin, tomatenpuree, champignons, gemalen kaas en spaghetti
                                    new { RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000009"), IngedrientId = Guid.Parse("00000000-0000-0000-0000-000000000005")},
                                    new { RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000009"), IngedrientId = Guid.Parse("00000000-0000-0000-0000-000000000003")},
                                    new { RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000009"), IngedrientId = Guid.Parse("00000000-0000-0000-0000-000000000007")},
                                    new { RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000009"), IngedrientId = Guid.Parse("00000000-0000-0000-0000-000000000014")},
                                    new { RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000009"), IngedrientId = Guid.Parse("00000000-0000-0000-0000-000000000006")},
                                    new { RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000009"), IngedrientId = Guid.Parse("00000000-0000-0000-0000-000000000008")},
                                    new { RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000009"), IngedrientId = Guid.Parse("00000000-0000-0000-0000-000000000004")},
                                    new { RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000009"), IngedrientId = Guid.Parse("00000000-0000-0000-0000-000000000011")},
                                    new { RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000009"), IngedrientId = Guid.Parse("00000000-0000-0000-0000-000000000012")},
                                    new { RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000009"), IngedrientId = Guid.Parse("00000000-0000-0000-0000-000000000013")},
                                    // Ongelooflijk goed gerecht heeft enkel melk
                                    new { RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000010"), IngedrientId = Guid.Parse("00000000-0000-0000-0000-000000000001")}
                                });
                        });
        }
    }
}
