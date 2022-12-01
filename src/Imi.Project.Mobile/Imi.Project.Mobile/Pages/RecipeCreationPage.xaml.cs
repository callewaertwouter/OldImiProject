using Imi.Project.Mobile.Domain.Services.Features;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Imi.Project.Mobile.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecipeCreationPage : ContentPage
    {
        private ISpeechToText _speechToText;

        public RecipeCreationPage()
        {
            InitializeComponent();

            try
            {
                _speechToText = DependencyService.Get<ISpeechToText>();
            }
            catch (Exception ex)
            {
                lblSpeechToText.Text = ex.Message;
            }

            MessagingCenter.Subscribe<ISpeechToText, string>(this, "STT", (sender, args) =>
            {
                btnSpeechToTextFinalResultReceived(args);
            });

            MessagingCenter.Subscribe<ISpeechToText>(this, "Final", (sender) =>
            {
                btnSpeechToText.IsEnabled = true;
            });

            MessagingCenter.Subscribe<IMessageSender, string>(this, "STT", (sender, args) =>
            {
                btnSpeechToTextFinalResultReceived(args);
            });
        }

        private void btnSpeechToTextFinalResultReceived(string args)
        {
            lblSpeechToText.Text = args;
        }

        private void btnSpeechToText_Clicked(object sender, EventArgs e)
        {
            // Speech-to-Text werkt enkel als het op Android is. Indien IOS of UWP, zal de button niet werken.
            if (Device.RuntimePlatform == Device.iOS || Device.RuntimePlatform == Device.UWP)
            {
                btnSpeechToText.IsEnabled = false;
            }

            try
            {
                _speechToText.StartSpeechToText();
            }
            catch (Exception ex)
            {
                lblSpeechToText.Text = ex.Message;
            }
        }
    }
}