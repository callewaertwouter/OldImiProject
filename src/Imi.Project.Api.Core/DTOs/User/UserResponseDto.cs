using Imi.Project.Api.Core.DTOs.Recipe;

namespace Imi.Project.Api.Core.DTOs.User
{
    public class UserResponseDto : BaseDto
    {
        public string Email { get; set; }
        public RecipeResponseDto Recipe { get; set; }
    }
}