using System.ComponentModel.DataAnnotations;

namespace Imi.Project.Api.Entities
{
    public class Recipe : BaseEntity
    {
        [Required]
        public string Title { get; set; }

        //TODO Props to add: List of ingedriënts, description and which user made it
    }
}
