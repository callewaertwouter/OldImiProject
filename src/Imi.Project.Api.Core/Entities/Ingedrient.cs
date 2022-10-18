using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Imi.Project.Api.Core.Entities
{
    public class Ingedrient : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        public Guid UnitOfMeasureId { get; set; }
        public UnitOfMeasure UnitOfMeasure { get; set; }

        // Many ingedrients can be used in many recipes
        public ICollection<Recipe> UsedInRecipes { get; set; }
    }
}
