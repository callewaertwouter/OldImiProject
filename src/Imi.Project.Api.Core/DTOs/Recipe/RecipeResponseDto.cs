using Imi.Project.Api.Core.DTOs.Ingedrient;

namespace Imi.Project.Api.Core.DTOs.Recipe
{
    public class RecipeResponseDto : BaseDto
    {
        public string Title { get; set; }
        public IngedrientResponseDto Ingedrients { get; set; }
    }
}