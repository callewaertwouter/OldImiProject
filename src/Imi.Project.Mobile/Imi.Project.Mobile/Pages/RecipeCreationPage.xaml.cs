using Imi.Project.Mobile.Domain.Services.Features;
using System;
using System.IO;
using System.Threading.Tasks;
using Xamarin.Essentials;
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

        // https://learn.microsoft.com/en-us/answers/questions/428458/how-do-i-use-xamarinessentials-mediapicker-with-mv.html
        // Check to bind the functions to UI (ImageCell or replace ImageCell with something better)

        private string photoPath;

        public string PhotoPath 
        {
            get => photoPath;

            set
            {
                if (photoPath == value) return;
                photoPath = value;
                OnPropertyChanged();
            }
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

        async Task TakePhotoAsync()
        {
            try
            {
                var photo = await MediaPicker.CapturePhotoAsync();
                await LoadPhotoAsync(photo);
                Console.WriteLine($"CapturePhotoAsync COMPLETED: {PhotoPath}");
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Feature is not supported on the device
            }
            catch (PermissionException pEx)
            {
                // Permissions not granted
            }
            catch (Exception ex)
            {
                Console.WriteLine($"CapturePhotoAsync THREW: {ex.Message}");
            }
        }

        async Task LoadPhotoAsync(FileResult photo)
        {
            // canceled
            if (photo == null)
            {
                PhotoPath = null;
                return;
            }
            // save the file into local storage
            var newFile = Path.Combine(FileSystem.CacheDirectory, photo.FileName);
            using (var stream = await photo.OpenReadAsync())
            using (var newStream = File.OpenWrite(newFile))
                await stream.CopyToAsync(newStream);

            PhotoPath = newFile;
        }
    }
}