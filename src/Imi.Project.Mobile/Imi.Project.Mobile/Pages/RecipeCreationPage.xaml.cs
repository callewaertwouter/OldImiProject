using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Imi.Project.Mobile.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecipeCreationPage : ContentPage
    {
        public RecipeCreationPage()
        {
            InitializeComponent();
        }

        private async void btnAdd_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RecipePage(), true);
        }

        private async void btnBack_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MenuPage(), true);
        }
    }
}