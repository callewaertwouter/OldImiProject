using System.ComponentModel.DataAnnotations;

namespace Imi.Project.Api.Core.Entities
{
    public class Ingedrient : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        //TODO Add prop for unit of measure (gram, liter, etc.)
    }
}
