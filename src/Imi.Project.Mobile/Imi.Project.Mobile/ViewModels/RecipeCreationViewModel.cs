using FluentValidation;
using FreshMvvm;
using Imi.Project.Mobile.Domain.Models;
using Imi.Project.Mobile.Domain.Services;
using Imi.Project.Mobile.Validators;
using System;
using System.Collections.Generic;
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

		private string ingredientName;
		public string IngredientName
		{
			get 
            { 
                return ingredientName; 
            }
			set
			{
				ingredientName = value;
				RaisePropertyChanged(nameof(IngredientName));
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
		public ICommand AddIngredientCommand => new Command(
			async () =>
			{
				try
				{
					if (!string.IsNullOrWhiteSpace(IngredientName))
					{
						if (currentRecipe.Ingredients == null)
						{
							currentRecipe.Ingredients = new List<Ingredient>();
						}

						var ingredient = new Ingredient { Name = IngredientName };
						currentRecipe.Ingredients.Add(ingredient);
						IngredientName = string.Empty;
					}
				}
				catch (Exception ex)
				{
					Debug.WriteLine(ex.Message);

					await CoreMethods.DisplayAlert("Error", "Sorry, ingedrienten kunnen niet geladen worden.", "OK");
				}
			});



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