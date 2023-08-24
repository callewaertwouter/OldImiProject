using Imi.Project.Api.Core.DTOs.Ingedrient;
using Imi.Project.Api.Core.DTOs.User;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Imi.Project.Api.Core.DTOs.Recipe
{
    public class RecipeRequestDto : BaseDto
    {
        [Required(ErrorMessage = "{0} is required!")]
        public string Title { get; set; }

        [Required(ErrorMessage = "{0} is required!")]
        public string Description { get; set; }

        public ICollection<IngedrientRequestDto> Ingedrients { get; set; }

        public UserRequestDto CreatedBy { get; set; }
    }
}
