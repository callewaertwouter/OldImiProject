using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Imi.Project.Mobile.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecipeListPage : ContentPage
    {
        public RecipeListPage()
        {
            InitializeComponent();
        }

        private async void btnBack_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MenuPage(), true);
        }
    }
}