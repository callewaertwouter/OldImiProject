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
			SKPaint backgroundPaint = new SKPaint
			{
				Shader = SKShader.CreateLinearGradient(
					new SKPoint(0, 0), new SKPoint(0, e.Info.Height),
					new SKColor[] { SKColors.Blue, SKColors.Purple },
					new float[] { 0, 1 },
					SKShaderTileMode.Clamp
				)
			};

			canvas.DrawRect(new SKRect(0, 0, e.Info.Width, e.Info.Height), backgroundPaint);

			SKPaint textPaint = new SKPaint
			{
				Color = SKColors.White,
				TextSize = 24
			};

			float x = viewModel.XPosition;
			float y = viewModel.YPosition;

			canvas.DrawText(viewModel.TextToDraw, x, y, textPaint);
		}

	}
}
