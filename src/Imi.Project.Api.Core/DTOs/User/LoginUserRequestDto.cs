namespace Imi.Project.Api.Core.DTOs.User
{
    public class LoginUserRequestDto
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}