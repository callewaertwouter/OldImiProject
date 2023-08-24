using Imi.Project.Api.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class IngedrientSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ingedrient>().HasData(
                new Ingedrient
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Name = "Melk",
                    UnitOfMeasure = "liter",
                    CreatedOn = DateTime.UtcNow,
                    LastEditedOn = DateTime.UtcNow
                },

                new Ingedrient
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    Name = "Laurier",
                    UnitOfMeasure = "takjes",
                    CreatedOn = DateTime.UtcNow,
                    LastEditedOn = DateTime.UtcNow
                },

                new Ingedrient
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    Name = "Gehakt",
                    UnitOfMeasure = "kilo",
                    CreatedOn = DateTime.UtcNow,
                    LastEditedOn = DateTime.UtcNow
                },

                new Ingedrient
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    Name = "Tomatenpuree",
                    UnitOfMeasure = "blik",
                    CreatedOn = DateTime.UtcNow,
                    LastEditedOn = DateTime.UtcNow
                },

                new Ingedrient
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000005"),
                    Name = "Boter",
                    UnitOfMeasure = "gram",
                    CreatedOn = DateTime.UtcNow,
                    LastEditedOn = DateTime.UtcNow
                },

                new Ingedrient
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000006"),
                    Name = "Paprika",
                    UnitOfMeasure = "",
                    CreatedOn = DateTime.UtcNow,
                    LastEditedOn = DateTime.UtcNow
                },

                new Ingedrient
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000007"),
                    Name = "Wortel",
                    UnitOfMeasure = "",
                    CreatedOn = DateTime.UtcNow,
                    LastEditedOn = DateTime.UtcNow
                },

                new Ingedrient
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000008"),
                    Name = "Ajuin",
                    UnitOfMeasure = "",
                    CreatedOn = DateTime.UtcNow,
                    LastEditedOn = DateTime.UtcNow
                },

                new Ingedrient
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000009"),
                    Name = "Kippenbouillon",
                    UnitOfMeasure = "liter",
                    CreatedOn = DateTime.UtcNow,
                    LastEditedOn = DateTime.UtcNow
                },

                new Ingedrient
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000010"),
                    Name = "Olijfolie",
                    UnitOfMeasure = "centiliter",
                    CreatedOn = DateTime.UtcNow,
                    LastEditedOn = DateTime.UtcNow
                },

                new Ingedrient
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000011"),
                    Name = "Champignons",
                    UnitOfMeasure = "bakjes",
                    CreatedOn = DateTime.UtcNow,
                    LastEditedOn = DateTime.UtcNow
                },

                new Ingedrient
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000012"),
                    Name = "Gemalen kaas",
                    UnitOfMeasure = "gram",
                    CreatedOn = DateTime.UtcNow,
                    LastEditedOn = DateTime.UtcNow
                },

                new Ingedrient
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000013"),
                    Name = "Spaghetti",
                    UnitOfMeasure = "",
                    CreatedOn = DateTime.UtcNow,
                    LastEditedOn = DateTime.UtcNow
                },

                new Ingedrient
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000014"),
                    Name = "Courgette",
                    UnitOfMeasure = "",
                    CreatedOn = DateTime.UtcNow,
                    LastEditedOn = DateTime.UtcNow
                }
                );
        }
    }
}
