using FreshMvvm;
using SkiaSharp;
using SkiaSharp.Views.Forms;

namespace Imi.Project.Mobile.ViewModels
{
    public class SkiaSharpViewModel : FreshBasePageModel
    {
        public SkiaSharpViewModel()
        {
            
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

            float x = 20;
            float y = 50;

            canvas.DrawText("Creative Recipes App Platform", x, y, textPaint);
        }
    }
}
