using System.ComponentModel.DataAnnotations;

namespace Imi.Project.Api.Core.DTOs.User
{
    public class UserRequestDto : BaseDto
    {
        [Required(ErrorMessage = "{0} is required!")]
        public string Email { get; set; }

        //TODO Add list of recipes so they show on requested user
    }
}