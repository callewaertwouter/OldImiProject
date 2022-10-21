using Imi.Project.Api.Core.DTOs.Ingedrient;
using Imi.Project.Api.Core.DTOs.User;

namespace Imi.Project.Api.Core.DTOs.Recipe
{
    public class RecipeResponseDto : BaseDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public IngedrientResponseDto Ingedrients { get; set; }
        public UserResponseDto CreatedByUser { get; set; }
    }
}