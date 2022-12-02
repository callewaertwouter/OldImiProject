using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Imi.Project.Mobile.ViewModels
{
    public class MenuViewModel : FreshBasePageModel
    {
        public MenuViewModel()
        {

        }

        public ICommand OpenRecipeCreationPageCommand => new Command(
            async () =>
            {
                await CoreMethods.PushPageModel<RecipeCreationViewModel>(true);
            }
            );

        public ICommand OpenRecipesPageCommand => new Command(
            async () =>
            {
                await CoreMethods.PushPageModel<RecipesViewModel>(true);
            }
            );

        public ICommand OpenQuizPageCommand => new Command(
            async () =>
            {
                await CoreMethods.PushPageModel<QuizViewModel>(true);
            }
            );
    }
}
