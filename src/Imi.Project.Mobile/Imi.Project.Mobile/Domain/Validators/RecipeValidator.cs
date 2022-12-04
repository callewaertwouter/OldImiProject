using FluentValidation;
using Imi.Project.Mobile.Domain.Models;

namespace Imi.Project.Mobile.Validators
{
    public class RecipeValidator : AbstractValidator<Recipe>
    {
        public RecipeValidator()
        {
            RuleFor(recipe => recipe.Title)
                .NotEmpty()
                .WithMessage("Vul een titel in!")
                .Length(3, 50)
                .WithMessage("Lengte van titel moet tussen 3 and 50 karakters zijn.");

            RuleFor(recipe => recipe.Description)
                .NotEmpty()
                .WithMessage("Vul een beschrijving van de bereiding in.")
                .Length(5, 5000)
                .WithMessage("Minstens 5 karakters en maximaal 5000 karakters. Het is een beschrijving, geen essay.");
        }
    }
}