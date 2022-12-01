using FreshMvvm;
using System.Windows.Input;
using Xamarin.Forms;

namespace Imi.Project.Mobile.ViewModels
{
    public class RecipeCreationViewModel : FreshBasePageModel
    {
        public RecipeCreationViewModel()
        {

        }

        public ICommand OpenRecipeDetailCommand => new Command(
            async () =>
            {
                await CoreMethods.PushPageModel<RecipeDetailViewModel>(true);
            }
            );

        public ICommand OpenMenuPageCommand => new Command(
            async () =>
            {
                await CoreMethods.PushPageModel<MenuViewModel>(true);
            }
            );
    }
}