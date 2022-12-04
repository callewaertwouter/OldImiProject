using Imi.Project.Mobile.Domain.Models;
using Imi.Project.Mobile.Validators;
using Xunit;

namespace Imi.Project.Tests
{
    public class RecipeValidatorTests
    {
        [Fact]
        public void GivenValidRecipe_WhenValidate_ReturnsSuccess()
        {
            // Arrange
            var goodRecipe = new Recipe();
            goodRecipe.Title = "Deze titel is lang genoeg";
            goodRecipe.Description = "Deze beschrijving is correct en lang genoeg";

            var validator = new RecipeValidator();

            // Act
            var validationResult = validator.Validate(goodRecipe);

            // Assert
            Assert.True(validationResult.IsValid);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("n")]
        public void RecipeTitleInvalid_WhenValidate_ReturnValidationError(string title)
        {
            // Arrange
            var badRecipe = new Recipe();
            badRecipe.Title = title;
            badRecipe.Description = "Deze beschrijving is lang genoeg om gevalideerd te worden";

            var validator = new RecipeValidator();

            // Act
            var validationResult = validator.Validate(badRecipe);

            // Assert
            Assert.False(validationResult.IsValid);
            Assert.Contains(nameof(Recipe.Title), validationResult.Errors.Select(e => e.PropertyName));
        }

        [Fact]
        public void RecipeDescriptionTooShort_WhenValidate_ReturnsValidationError()
        {
            // Arrange
            var badRecipe = new Recipe();
            badRecipe.Title = "Correcte titel";
            badRecipe.Description = "n";

            var validator = new RecipeValidator();

            // Act
            var validationResult = validator.Validate(badRecipe);

            // Assert
            Assert.False(validationResult.IsValid);
            Assert.Contains(nameof(Recipe.Description), validationResult.Errors.Select(e => e.PropertyName));
        }
    }
}