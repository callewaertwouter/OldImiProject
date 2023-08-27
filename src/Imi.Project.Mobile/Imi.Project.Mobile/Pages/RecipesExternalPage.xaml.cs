using Imi.Project.Mobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Imi.Project.Mobile.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RecipesExternalPage : ContentPage
	{
		public RecipesExternalPage()
		{
			InitializeComponent();

			var viewModel = new RecipesExternalViewModel();
			BindingContext = viewModel;
			LoadRecipes(viewModel);
		}

		private async void LoadRecipes(RecipesExternalViewModel viewModel)
		{
			await viewModel.LoadRecipesAsync();
		}

		private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			if (e.SelectedItem == null)
				return;
		}
	}
}