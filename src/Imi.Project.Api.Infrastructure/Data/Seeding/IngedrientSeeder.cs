using Imi.Project.Api.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class IngedrientSeeder
    {
        //TODO Add units of measure to each ingedrient
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ingedrient>().HasData(
                new Ingedrient
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Name = "Melk",
                    UnitOfMeasureId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    CreatedOn = DateTime.UtcNow,
                    LastEditedOn = DateTime.UtcNow
                },

                new Ingedrient
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    Name = "Laurier",
                    UnitOfMeasureId = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    CreatedOn = DateTime.UtcNow,
                    LastEditedOn = DateTime.UtcNow
                },

                new Ingedrient
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    Name = "Gehakt",
                    UnitOfMeasureId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    CreatedOn = DateTime.UtcNow,
                    LastEditedOn = DateTime.UtcNow
                },

                new Ingedrient
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    Name = "Tomatenpuree",
                    UnitOfMeasureId = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    CreatedOn = DateTime.UtcNow,
                    LastEditedOn = DateTime.UtcNow
                },

                new Ingedrient
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000005"),
                    Name = "Boter",
                    UnitOfMeasureId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    CreatedOn = DateTime.UtcNow,
                    LastEditedOn = DateTime.UtcNow
                },

                new Ingedrient
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000006"),
                    Name = "Paprika",
                    UnitOfMeasureId = Guid.Parse("00000000-0000-0000-0000-000000000011"),
                    CreatedOn = DateTime.UtcNow,
                    LastEditedOn = DateTime.UtcNow
                },

                new Ingedrient
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000007"),
                    Name = "Wortel",
                    UnitOfMeasureId = Guid.Parse("00000000-0000-0000-0000-000000000011"),
                    CreatedOn = DateTime.UtcNow,
                    LastEditedOn = DateTime.UtcNow
                },

                new Ingedrient
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000008"),
                    Name = "Ajuin",
                    UnitOfMeasureId = Guid.Parse("00000000-0000-0000-0000-000000000011"),
                    CreatedOn = DateTime.UtcNow,
                    LastEditedOn = DateTime.UtcNow
                },

                new Ingedrient
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000009"),
                    Name = "Kippenbouillon",
                    UnitOfMeasureId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    CreatedOn = DateTime.UtcNow,
                    LastEditedOn = DateTime.UtcNow
                },

                new Ingedrient
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000010"),
                    Name = "Olijfolie",
                    UnitOfMeasureId = Guid.Parse("00000000-0000-0000-0000-000000000007"),
                    CreatedOn = DateTime.UtcNow,
                    LastEditedOn = DateTime.UtcNow
                },

                new Ingedrient
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000011"),
                    Name = "Champignons",
                    UnitOfMeasureId = Guid.Parse("00000000-0000-0000-0000-000000000008"),
                    CreatedOn = DateTime.UtcNow,
                    LastEditedOn = DateTime.UtcNow
                },

                new Ingedrient
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000012"),
                    Name = "Gemalen kaas",
                    UnitOfMeasureId = Guid.Parse("00000000-0000-0000-0000-000000000009"),
                    CreatedOn = DateTime.UtcNow,
                    LastEditedOn = DateTime.UtcNow
                },

                new Ingedrient
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000013"),
                    Name = "Spaghetti",
                    UnitOfMeasureId = Guid.Parse("00000000-0000-0000-0000-000000000009"),
                    CreatedOn = DateTime.UtcNow,
                    LastEditedOn = DateTime.UtcNow
                },

                new Ingedrient
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000014"),
                    Name = "Courgette",
                    UnitOfMeasureId = Guid.Parse("00000000-0000-0000-0000-000000000011"),
                    CreatedOn = DateTime.UtcNow,
                    LastEditedOn = DateTime.UtcNow
                }
                );
        }
    }
}
