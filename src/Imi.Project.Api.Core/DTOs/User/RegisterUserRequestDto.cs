using System;
using System.ComponentModel.DataAnnotations;

namespace Imi.Project.Api.Core.DTOs.User
{
    public class RegisterUserRequestDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Both password fields do not match each other!")]
        public string ConfirmPassword { get; set; }
        [Required]
        public DateTime Birthday { get; set; }

        public bool HasApprovedTermsAndConditions { get; set; }
    }
}