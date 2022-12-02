using FreshMvvm;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Imi.Project.Mobile.ViewModels
{
    public class QuizViewModel : FreshBasePageModel
    {
        public QuizViewModel()
        {

        }

        public ICommand OpenBlazorQuizCommand => new Command(
            async () =>
            {
                await OpenBrowser(new Uri("https://localhost:7219/quiz"));
            });

        // Xamarin Essentials: Open Browser
        // https://learn.microsoft.com/en-us/xamarin/essentials/open-browser?tabs=uwp
        public async Task OpenBrowser(Uri uri)
        {
            var current = Connectivity.NetworkAccess;

            try
            {
                if (current == NetworkAccess.Internet)
                {
                    await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Probleem!", "Start ook Blazor op om de quiz te bekijken.", "Ok");
                }

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}