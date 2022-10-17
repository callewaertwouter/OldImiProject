using System;

namespace Imi.Project.Api.Core.Entities
{
    public class UnitOfMeasure
    {
        // This class only contains units of measure (gram, liter, etc.) and will not inherit BaseEntity as users will not create units on their own

        public Guid Id { get; set; }
        public string MeasureUnit { get; set; }
    }
}
