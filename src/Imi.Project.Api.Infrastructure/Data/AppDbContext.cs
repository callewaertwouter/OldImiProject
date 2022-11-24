using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Infrastructure.Data.Seeding;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace Imi.Project.Api.Infrastructure.Data
{
    public class AppDbContext : IdentityDbContext<User>
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

            modelBuilder.Entity<Recipe>()
                .HasMany(r => r.Ingedrients)
                .WithMany(i => i.Recipes)
                .UsingEntity(x => x.HasData(
                    // Testrecept heeft enkel melk om dit te testen
                    new { RecipesId = Guid.Parse("00000000-0000-0000-0000-000000000001"), IngedrientsId = Guid.Parse("00000000-0000-0000-0000-000000000001") },
                    // Witte saus heeft boter en melk
                    new { RecipesId = Guid.Parse("00000000-0000-0000-0000-000000000002"), IngedrientsId = Guid.Parse("00000000-0000-0000-0000-000000000005") },
                    new { RecipesId = Guid.Parse("00000000-0000-0000-0000-000000000002"), IngedrientsId = Guid.Parse("00000000-0000-0000-0000-000000000001") },
                    // Gemarineerde brochetten heeft boter, paprika, ajuin en gehakt
                    new { RecipesId = Guid.Parse("00000000-0000-0000-0000-000000000003"), IngedrientsId = Guid.Parse("00000000-0000-0000-0000-000000000005") },
                    new { RecipesId = Guid.Parse("00000000-0000-0000-0000-000000000003"), IngedrientsId = Guid.Parse("00000000-0000-0000-0000-000000000006") },
                    new { RecipesId = Guid.Parse("00000000-0000-0000-0000-000000000003"), IngedrientsId = Guid.Parse("00000000-0000-0000-0000-000000000008") },
                    new { RecipesId = Guid.Parse("00000000-0000-0000-0000-000000000003"), IngedrientsId = Guid.Parse("00000000-0000-0000-0000-000000000003") },
                    // Champignonsoep heeft champignons en olijfolie
                    new { RecipesId = Guid.Parse("00000000-0000-0000-0000-000000000004"), IngedrientsId = Guid.Parse("00000000-0000-0000-0000-000000000011") },
                    new { RecipesId = Guid.Parse("00000000-0000-0000-0000-000000000004"), IngedrientsId = Guid.Parse("00000000-0000-0000-0000-000000000010") },
                    // Gehaktbrood heeft boter, gehakt en ajuin
                    new { RecipesId = Guid.Parse("00000000-0000-0000-0000-000000000005"), IngedrientsId = Guid.Parse("00000000-0000-0000-0000-000000000005") },
                    new { RecipesId = Guid.Parse("00000000-0000-0000-0000-000000000005"), IngedrientsId = Guid.Parse("00000000-0000-0000-0000-000000000003") },
                    new { RecipesId = Guid.Parse("00000000-0000-0000-0000-000000000005"), IngedrientsId = Guid.Parse("00000000-0000-0000-0000-000000000008") },
                    // Hamburger heeft gehakt en wortel
                    new { RecipesId = Guid.Parse("00000000-0000-0000-0000-000000000006"), IngedrientsId = Guid.Parse("00000000-0000-0000-0000-000000000003") },
                    new { RecipesId = Guid.Parse("00000000-0000-0000-0000-000000000006"), IngedrientsId = Guid.Parse("00000000-0000-0000-0000-000000000007") },
                    // Viskroketjes met patatten heeft enkel olijfolie
                    new { RecipesId = Guid.Parse("00000000-0000-0000-0000-000000000007"), IngedrientsId = Guid.Parse("00000000-0000-0000-0000-000000000010") },
                    // Grillworst met puree heeft boter, melk en gehakt
                    new { RecipesId = Guid.Parse("00000000-0000-0000-0000-000000000008"), IngedrientsId = Guid.Parse("00000000-0000-0000-0000-000000000005") },
                    new { RecipesId = Guid.Parse("00000000-0000-0000-0000-000000000008"), IngedrientsId = Guid.Parse("00000000-0000-0000-0000-000000000001") },
                    new { RecipesId = Guid.Parse("00000000-0000-0000-0000-000000000008"), IngedrientsId = Guid.Parse("00000000-0000-0000-0000-000000000003") },
                    // Spaghetti bolognaise heeft boter, gehakt, wortel, courgette, paprika, ajuin, tomatenpuree, champignons, gemalen kaas en spaghetti
                    new { RecipesId = Guid.Parse("00000000-0000-0000-0000-000000000009"), IngedrientsId = Guid.Parse("00000000-0000-0000-0000-000000000005") },
                    new { RecipesId = Guid.Parse("00000000-0000-0000-0000-000000000009"), IngedrientsId = Guid.Parse("00000000-0000-0000-0000-000000000003") },
                    new { RecipesId = Guid.Parse("00000000-0000-0000-0000-000000000009"), IngedrientsId = Guid.Parse("00000000-0000-0000-0000-000000000007") },
                    new { RecipesId = Guid.Parse("00000000-0000-0000-0000-000000000009"), IngedrientsId = Guid.Parse("00000000-0000-0000-0000-000000000014") },
                    new { RecipesId = Guid.Parse("00000000-0000-0000-0000-000000000009"), IngedrientsId = Guid.Parse("00000000-0000-0000-0000-000000000006") },
                    new { RecipesId = Guid.Parse("00000000-0000-0000-0000-000000000009"), IngedrientsId = Guid.Parse("00000000-0000-0000-0000-000000000008") },
                    new { RecipesId = Guid.Parse("00000000-0000-0000-0000-000000000009"), IngedrientsId = Guid.Parse("00000000-0000-0000-0000-000000000004") },
                    new { RecipesId = Guid.Parse("00000000-0000-0000-0000-000000000009"), IngedrientsId = Guid.Parse("00000000-0000-0000-0000-000000000011") },
                    new { RecipesId = Guid.Parse("00000000-0000-0000-0000-000000000009"), IngedrientsId = Guid.Parse("00000000-0000-0000-0000-000000000012") },
                    new { RecipesId = Guid.Parse("00000000-0000-0000-0000-000000000009"), IngedrientsId = Guid.Parse("00000000-0000-0000-0000-000000000013") },
                    // Ongelooflijk goed gerecht heeft enkel melk
                    new { RecipesId = Guid.Parse("00000000-0000-0000-0000-000000000010"), IngedrientsId = Guid.Parse("00000000-0000-0000-0000-000000000001") }
                    ));
        }
    }
}