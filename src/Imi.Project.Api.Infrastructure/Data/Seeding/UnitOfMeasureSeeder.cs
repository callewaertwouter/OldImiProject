using Imi.Project.Api.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class UnitOfMeasureSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UnitOfMeasure>().HasData(
                new UnitOfMeasure { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), MeasureUnit = "gram" },
                new UnitOfMeasure { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), MeasureUnit = "liter" },
                new UnitOfMeasure { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), MeasureUnit = "blik(ken)" },
                new UnitOfMeasure { Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), MeasureUnit = "tak(ken)" },
                new UnitOfMeasure { Id = Guid.Parse("00000000-0000-0000-0000-000000000005"), MeasureUnit = "blaadje(s)" },
                new UnitOfMeasure { Id = Guid.Parse("00000000-0000-0000-0000-000000000006"), MeasureUnit = "deciliter" },
                new UnitOfMeasure { Id = Guid.Parse("00000000-0000-0000-0000-000000000007"), MeasureUnit = "centiliter" },
                new UnitOfMeasure { Id = Guid.Parse("00000000-0000-0000-0000-000000000008"), MeasureUnit = "bakje(s)" },
                new UnitOfMeasure { Id = Guid.Parse("00000000-0000-0000-0000-000000000009"), MeasureUnit = "vrij naar keuze" },
                new UnitOfMeasure { Id = Guid.Parse("00000000-0000-0000-0000-000000000010"), MeasureUnit = "geen" },
                new UnitOfMeasure { Id = Guid.Parse("00000000-0000-0000-0000-000000000010"), MeasureUnit = " " }
                );
        }
    }
}
