using Imi.Project.Api.Core.Services.Interfaces;
using Imi.Project.Api.Core.Services.Models.RecipeService;
using Imi.Project.Shared.Models.RecipeModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Imi.Project.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IRecipeService _recipeService;

        public MainWindow(IRecipeService recipeService)
        {
            _recipeService = recipeService;

            InitializeComponent();
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var result = await _recipeService.GetAllRecipes();

            if (result.IsSuccess == false)
            {
                ShowErrorMessages(result);
            }
            else
            {
                var recipes = new List<RecipeItemViewModel>();
                foreach (var recipe in result.Recipes)
                {
                    recipes.Add(new RecipeItemViewModel { Id = recipe.Id, Title = recipe.Title });
                }
                dgRecipes.ItemsSource = recipes;
            }
        }

        private async void dgRecipes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ClearFeedback();

            if (dgRecipes.SelectedItem != null)
            {
                var selectedRecipe = (RecipeItemViewModel)dgRecipes.SelectedItem;

                var result = await _recipeService.GetRecipeById(selectedRecipe.Id);

                if (result.IsSuccess == false)
                {
                    ShowErrorMessages(result);
                }
                else
                {
                    foreach (var recipe in result.Recipes)
                    {
                        lblRecipeDetailId.Content = recipe.Id;
                        lblRecipeDetailTitle.Content = recipe.Title;

                        //TODO Add ingedrients to show
                    }
                }
            }
        }

        private async void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            ClearFeedback();

            var searchInput = txtSearchInput.Text;
            var result = await _recipeService.SearchRecipeByName(searchInput);

            if (result.IsSuccess == false)
            {
                ShowErrorMessages(result);
            }
            else
            {
                var recipes = new List<RecipeItemViewModel>();
                foreach (var recipe in result.Recipes)
                {
                    recipes.Add(new RecipeItemViewModel { Id = recipe.Id, Title = recipe.Title });
                }
                dgRecipes.ItemsSource = recipes;

                if (recipes.Count == 0)
                {
                    lblFeedback.Content = $"Er zijn geen recepten gevonden met de naam {searchInput}.";
                    lblFeedback.Background = Brushes.Orange;
                }
            }
        }

        private void ShowErrorMessages(ViewRecipesResult result)
        {
            StringBuilder errorMessages = new StringBuilder();

            foreach (var error in result.ValidationResults)
            {
                errorMessages.Append(error.ErrorMessage);
            }

            lblFeedback.Content = errorMessages;
            lblFeedback.Background = Brushes.OrangeRed;
        }

        private void ClearFeedback()
        {
            lblFeedback.Content = string.Empty;
            lblFeedback.Background = Brushes.White;
        }
    }
}
