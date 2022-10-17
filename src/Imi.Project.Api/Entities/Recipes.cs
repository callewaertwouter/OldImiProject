using System.ComponentModel.DataAnnotations;

namespace Imi.Project.Api.Entities
{
    public class Recipes : BaseEntity
    {
        [Required]
        public string Title { get; set; }

        // Props to add: List of ingedriënts, description and which user made it
    }
}
