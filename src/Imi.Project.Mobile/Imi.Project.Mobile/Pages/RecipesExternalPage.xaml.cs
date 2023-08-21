using Imi.Project.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Imi.Project.Mobile.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RecipesExternalPage : ContentPage
	{
		public RecipesExternalPage ()
        {
            InitializeComponent();

            BindingContext = new RecipesExternalViewModel();
            LoadRecipes();
        }

        private async void LoadRecipes()
        {
            var viewModel = (RecipesExternalViewModel)BindingContext;
            await viewModel.LoadRecipesAsync();
        }

        private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
        }
    }
}