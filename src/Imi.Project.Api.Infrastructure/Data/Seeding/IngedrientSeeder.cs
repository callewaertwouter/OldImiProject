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
                    CreatedOn = DateTime.UtcNow,
                    LastEditedOn = DateTime.UtcNow
                },

                new Ingedrient
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    Name = "Laurier",
                    CreatedOn = DateTime.UtcNow,
                    LastEditedOn = DateTime.UtcNow
                },

                new Ingedrient
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    Name = "Gehakt",
                    CreatedOn = DateTime.UtcNow,
                    LastEditedOn = DateTime.UtcNow
                },

                new Ingedrient
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    Name = "Tomatenpuree",
                    CreatedOn = DateTime.UtcNow,
                    LastEditedOn = DateTime.UtcNow
                },

                new Ingedrient
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000005"),
                    Name = "Boter",
                    CreatedOn = DateTime.UtcNow,
                    LastEditedOn = DateTime.UtcNow
                },

                new Ingedrient
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000006"),
                    Name = "Paprika",
                    CreatedOn = DateTime.UtcNow,
                    LastEditedOn = DateTime.UtcNow
                },

                new Ingedrient
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000007"),
                    Name = "Wortel",
                    CreatedOn = DateTime.UtcNow,
                    LastEditedOn = DateTime.UtcNow
                },

                new Ingedrient
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000008"),
                    Name = "Ajuin",
                    CreatedOn = DateTime.UtcNow,
                    LastEditedOn = DateTime.UtcNow
                },

                new Ingedrient
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000009"),
                    Name = "Kippenbouillon",
                    CreatedOn = DateTime.UtcNow,
                    LastEditedOn = DateTime.UtcNow
                },

                new Ingedrient
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000010"),
                    Name = "Olijfolie",
                    CreatedOn = DateTime.UtcNow,
                    LastEditedOn = DateTime.UtcNow
                },

                new Ingedrient
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000011"),
                    Name = "Champignons",
                    CreatedOn = DateTime.UtcNow,
                    LastEditedOn = DateTime.UtcNow
                },

                new Ingedrient
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000012"),
                    Name = "Gemalen kaas",
                    CreatedOn = DateTime.UtcNow,
                    LastEditedOn = DateTime.UtcNow
                },

                new Ingedrient
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000013"),
                    Name = "Spaghetti",
                    CreatedOn = DateTime.UtcNow,
                    LastEditedOn = DateTime.UtcNow
                },

                new Ingedrient
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000014"),
                    Name = "Courgette",
                    CreatedOn = DateTime.UtcNow,
                    LastEditedOn = DateTime.UtcNow
                }
                );
        }
    }
}
