using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Imi.Project.Mobile.ViewModels
{
    public class RegisterViewModel : FreshBasePageModel
    {
        public RegisterViewModel()
        {

        }

        public ICommand OpenMenuPageCommand => new Command(
            async () =>
            {
                await CoreMethods.PushPageModel<MenuViewModel>(true);
            }
            );        
        
        public ICommand OpenMainPageCommand => new Command(
            async () =>
            {
                await CoreMethods.PushPageModel<MainViewModel>(true);
            }
            );
    }
}
