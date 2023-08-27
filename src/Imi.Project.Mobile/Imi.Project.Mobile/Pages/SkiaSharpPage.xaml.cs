using Imi.Project.Mobile.ViewModels;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Imi.Project.Mobile.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SkiaSharpPage : ContentPage
    {
		private SkiaSharpViewModel viewModel;

		public SkiaSharpPage()
		{
			InitializeComponent();

			viewModel = new SkiaSharpViewModel();
			BindingContext = viewModel;
			canvasView.PaintSurface += OnPaintSurface;
		}

		private void OnPaintSurface(object sender, SKPaintSurfaceEventArgs e)
		{
			SKSurface surface = e.Surface;
			SKCanvas canvas = surface.Canvas;

			canvas.Clear(SKColors.White);

			SKPaint textPaint = new SKPaint
			{
				Color = SKColors.Black,
				TextSize = 24
			};

			float x = viewModel.XPosition;
			float y = viewModel.YPosition;

			canvas.DrawText(viewModel.TextToDraw, x, y, textPaint);
		}

	}
}
