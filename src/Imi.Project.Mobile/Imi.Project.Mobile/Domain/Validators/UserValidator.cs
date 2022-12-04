using FluentValidation;
using Imi.Project.Mobile.Domain.Models;

namespace Imi.Project.Mobile.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(user => user.Email)
                .NotEmpty()
                .WithMessage("Vul een e-mail adres in!")
                .Length(3, 30)
                .WithMessage("Email tussen 3 en 30 karakters.");
        }
    }
}