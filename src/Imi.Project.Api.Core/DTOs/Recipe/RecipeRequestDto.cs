using System.ComponentModel.DataAnnotations;

namespace Imi.Project.Api.Core.DTOs.Recipe
{
    public class RecipeRequestDto : BaseDto
    {
        [Required(ErrorMessage = "{0} is required!")]
        public string Title { get; set; }

        //TODO Add list of ingedrients so they show on requested recipe
    }
}