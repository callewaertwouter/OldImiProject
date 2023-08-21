using Windows.ApplicationModel.Activation;
using Xamarin.Forms;

namespace Imi.Project.Mobile.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new Imi.Project.Mobile.App());
        }

        //protected override void OnLaunched(LaunchActivatedEventArgs e)
        //{
        //    SkiaSharp.Views.UWP.SKCanvasViewRenderer.Init();

        //    base.OnLaunched(e);
        //}
    }
}
