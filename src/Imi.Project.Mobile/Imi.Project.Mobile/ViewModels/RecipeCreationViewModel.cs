using FluentValidation;
using FreshMvvm;
using Imi.Project.Mobile.Domain.Models;
using Imi.Project.Mobile.Domain.Services;
using Imi.Project.Mobile.Validators;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace Imi.Project.Mobile.ViewModels
{
    public class RecipeCreationViewModel : FreshBasePageModel
    {
        private Recipe currentRecipe;
        private IValidator recipeValidator;
        private readonly IRecipeService _recipeService;

        public RecipeCreationViewModel(IRecipeService recipeService)
        {
            currentRecipe = new Recipe();
            _recipeService = recipeService;
            recipeValidator = new RecipeValidator();
        }

        #region Properties
        private string recipeTitle;
        public string RecipeTitle 
        {
            get
            {
                return recipeTitle;
            }

            set
            {
                recipeTitle = value;
                RaisePropertyChanged(nameof(recipeTitle));
            }
        }

        private string recipeDescription;
        public string RecipeDescription 
        {
            get
            {
                return recipeDescription;
            }

            set
            {
                recipeDescription = value;
                RaisePropertyChanged(nameof(recipeDescription));
            }
        }

        private string recipeDescriptionError;
        public string RecipeDescriptionError 
        {
            get
            {
                return recipeDescriptionError;
            }

            set
            {
                recipeDescriptionError = value;
                RaisePropertyChanged(nameof(RecipeDescriptionError));
                RaisePropertyChanged(nameof(RecipeDescriptionErrorVisible));
            }
        
        }

        public bool RecipeDescriptionErrorVisible 
        {
            get
            {
                return !string.IsNullOrWhiteSpace(RecipeDescriptionError);
            } 
        }
        #endregion

        #region Functions
        private void SaveCurrentRecipe()
        {
            currentRecipe.Id = Guid.NewGuid();
            currentRecipe.Title = RecipeTitle;
            currentRecipe.Description = RecipeDescription;
            _recipeService.AddRecipe(currentRecipe);

            //TODO: Add image, list of ingedrients (required) and which user created it (requires login which requires API connection)
        }

        private bool Validate(Recipe recipe)
        {
            var validationResult = recipeValidator.Validate((IValidationContext)recipe);

            foreach (var error in validationResult.Errors)
            {
                if (error.PropertyName == nameof(recipe.Description))
                {
                    RecipeDescriptionError = error.ErrorMessage;
                }
            }

            return validationResult.IsValid;
        }
        #endregion

        #region Commands
        public ICommand SaveRecipeCommand => new Command(
            async () =>
            {
                try
                {
                    SaveCurrentRecipe();

                    if (Validate(currentRecipe))
                    {
                        if (currentRecipe.Id == Guid.Empty)
                        {
                            currentRecipe.Id = Guid.NewGuid();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }

                await CoreMethods.PushPageModel<RecipeDetailViewModel>(currentRecipe.Id);
            });

        public ICommand OpenMenuPageCommand => new Command(
            async () =>
            {
                await CoreMethods.PushPageModel<MenuViewModel>(true);
            }
            );

        #endregion
    }
}