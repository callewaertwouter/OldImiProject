using System;
using Windows.UI.Notifications;

namespace Imi.Project.Mobile.Plugin
{
	public class PushNotificationForUsers
	{
		public void PushNotification(string recipeName)
		{
			// Code voor de push notificatie
			var toastXml = ToastNotificationManager.GetTemplateContent(ToastTemplateType.ToastText01);
			var textElements = toastXml.GetElementsByTagName("text");
			textElements[0].AppendChild(toastXml.CreateTextNode($"New Recipe: {recipeName}"));

			// Timer voor de notificatie
			var toast = new ScheduledToastNotification(toastXml, DateTime.Now.AddSeconds(5));
			ToastNotificationManager.CreateToastNotifier().AddToSchedule(toast);
		}
	}
}