using Imi.Project.Api.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class UnitOfMeasureSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UnitOfMeasure>().HasData(
                new UnitOfMeasure { MeasureUnit = "gram" },
                new UnitOfMeasure { MeasureUnit = "liter" },
                new UnitOfMeasure { MeasureUnit = "blik(ken)" },
                new UnitOfMeasure { MeasureUnit = "tak(ken)" },
                new UnitOfMeasure { MeasureUnit = "blaadje(s)" },
                new UnitOfMeasure { MeasureUnit = "deciliter" },
                new UnitOfMeasure { MeasureUnit = "centiliter" },
                new UnitOfMeasure { MeasureUnit = "bakje(s)" },
                new UnitOfMeasure { MeasureUnit = "vrij naar keuze" },
                new UnitOfMeasure { MeasureUnit = "geen" }
                );
        }
    }
}
