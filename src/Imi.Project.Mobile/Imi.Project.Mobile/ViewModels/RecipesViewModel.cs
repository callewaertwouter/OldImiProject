using FreshMvvm;
using Imi.Project.Mobile.Domain.Models;
using Imi.Project.Mobile.Domain.Services;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Imi.Project.Mobile.ViewModels
{
    public class RecipesViewModel : FreshBasePageModel
    {
        protected readonly IRecipeService _recipeService;

        public RecipesViewModel(IRecipeService recipeService)
        {
            _recipeService = recipeService;
        }

        protected override async void ViewIsAppearing(object sender, EventArgs e)
        {
            var recipes = await _recipeService.GetRecipes();

            Recipes = new ObservableCollection<Recipe>(recipes);
        }

        private ObservableCollection<Recipe> recipes;

        public ObservableCollection<Recipe> Recipes
        {
            get
            {
                return recipes;
            }
            set
            {
                recipes = value;
                RaisePropertyChanged();
            }
        }

        public ICommand OpenRecipeDetailCommand => new Command<Guid>(
            (recipeId) =>
            {
                CoreMethods.PushPageModel<RecipeDetailViewModel>(recipeId);
            }
            );

        public ICommand OpenMenuPageCommand => new Command(
            async () =>
            {
                await CoreMethods.PushPageModel<MenuViewModel>(true);
            }
            );

        public ICommand OpenBrowserCommand => new Command(
            async () =>
            {
                await OpenBrowser(new Uri("https://www.google.be/"));
            });

        // Xamarin Essentials: Open Browser
        // https://learn.microsoft.com/en-us/xamarin/essentials/open-browser?tabs=uwp
        public async Task OpenBrowser(Uri uri)
        {
            var current = Connectivity.NetworkAccess;

            try
            {
                if (current == NetworkAccess.Internet)
                {
                    await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Probleem!", "Controleer uw internetverbinding.", "Ok");
                }

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}