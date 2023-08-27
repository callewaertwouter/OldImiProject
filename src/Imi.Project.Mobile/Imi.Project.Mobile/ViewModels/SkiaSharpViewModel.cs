using FreshMvvm;

namespace Imi.Project.Mobile.ViewModels
{
	public class SkiaSharpViewModel : FreshBasePageModel
	{
		public SkiaSharpViewModel()
		{

		}

		private string textToDraw = "Creative Recipes App Platform";
		public string TextToDraw
		{
			get { return textToDraw; }
			set { textToDraw = value; RaisePropertyChanged(); }
		}

		private float xPosition = 20;
		public float XPosition
		{
			get { return xPosition; }
			set { xPosition = value; RaisePropertyChanged(); }
		}

		private float yPosition = 20;
		public float YPosition
		{
			get { return yPosition; }
			set { yPosition = value; RaisePropertyChanged(); }
		}
	}
}