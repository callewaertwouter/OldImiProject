using Imi.Project.Api.Core.DTOs.Ingedrient;
using Imi.Project.Api.Core.DTOs.User;
using System.Collections.Generic;

namespace Imi.Project.Api.Core.DTOs.Recipe
{
    public class RecipeResponseDto : BaseDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<IngedrientResponseDto> Ingedrients { get; set; }
        public UserResponseDto CreatedByUser { get; set; }
    }
}