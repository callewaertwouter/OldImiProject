using Imi.Project.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Imi.Project.Api.Data.Seeding
{
    public class UnitOfMeasureSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UnitOfMeasure>().HasData(
                new UnitOfMeasure { MeasureUnit = "gram"},
                new UnitOfMeasure { MeasureUnit = "liter" },
                new UnitOfMeasure { MeasureUnit = "blik(ken)" },
                new UnitOfMeasure { MeasureUnit = "tak(ken)" },
                new UnitOfMeasure { MeasureUnit = "blaadje(s)" }
                );
        }
    }
}
