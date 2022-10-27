using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Imi.Project.Mobile.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private async void btnAddRecipe_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RecipeCreationPage(), true);
        }

        private async void btnViewRecipes_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RecipeListPage(), true);
        }

        private async void btnQuiz_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QuizPage(), true);
        }

        private async void btnQuit_Clicked(object sender, EventArgs e)
        {
            bool goQuit = await DisplayAlert("Terugkeren?", "Weet je zeker dat je de app wilt afsluiten?", "Ja", "Nee");

            if (goQuit)
            {
                Environment.Exit(0);
            }
        }
    }
}