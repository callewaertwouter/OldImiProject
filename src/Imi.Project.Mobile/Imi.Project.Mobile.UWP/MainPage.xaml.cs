﻿namespace Imi.Project.Mobile.UWP
{
	public sealed partial class MainPage
	{
		public MainPage()
		{
			this.InitializeComponent();

			LoadApplication(new Mobile.App());
		}
	}
}