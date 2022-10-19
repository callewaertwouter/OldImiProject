using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Imi.Project.Api.Core.Entities
{
    public class Recipe : BaseEntity
    {
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }

        // Many recipes will use many ingedriënts
        public ICollection<RecipeIngedrient> ListOfIngedrients { get; set; }

        //TODO Prop to add: Which user made it (CreatedBy)
    }
}
