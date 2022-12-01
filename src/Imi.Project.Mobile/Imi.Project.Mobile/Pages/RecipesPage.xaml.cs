using Imi.Project.Mobile.Domain.Models;
using Imi.Project.Mobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Imi.Project.Mobile.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecipesPage : ContentPage
    {
        public RecipesPage()
        {
            InitializeComponent();
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var viewModel = (RecipesViewModel) BindingContext;
            var selectedRecipe = (Recipe)e.Item;

            viewModel.OpenRecipeDetailCommand.Execute(selectedRecipe.Id);
        }
    }
}