using FreshMvvm;
using System.Windows.Input;
using Xamarin.Forms;

namespace Imi.Project.Mobile.ViewModels
{
    public class MainViewModel : FreshBasePageModel
    {
        public MainViewModel()
        {

        }

        public ICommand OpenRegisterPageCommand => new Command(
            async () =>
            {
                await CoreMethods.PushPageModel<RegisterViewModel>(true);
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