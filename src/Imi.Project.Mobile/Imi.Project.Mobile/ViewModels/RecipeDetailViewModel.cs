using FreshMvvm;
using Imi.Project.Mobile.Domain.Services;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Imi.Project.Mobile.ViewModels
{
    public class RecipeDetailViewModel : FreshBasePageModel
    {
        protected readonly IRecipeService _recipeService;

        public RecipeDetailViewModel(IRecipeService recipeService)
        {
            _recipeService = recipeService;
        }

        public override void Init(object initData)
        {
            if (initData is Guid)
            {
                Guid recipeId = (Guid)initData;
                var recipe = _recipeService.GetRecipe(recipeId);

                RecipeTitle = recipe.Result.Title;
                RecipeDescription = recipe.Result.Description;
            }
        }

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
                RaisePropertyChanged();
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
                RaisePropertyChanged();
            }
        }

        public ICommand OpenMenuPageCommand => new Command(
            async () =>
            {
                await CoreMethods.PushPageModel<MenuViewModel>(true);
            }
            );
    }
}
