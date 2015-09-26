using System;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using System.Linq;
using Android.App;


[assembly: ExportRenderer(
typeof(RenderersEServices.CustomNavigationPage),
typeof(RenderersEServices.Droid.CustomNavigationPage))]
namespace RenderersEServices.Droid
{
	public class CustomNavigationPage : NavigationRenderer
	{
		public CustomNavigationPage () 
		{
		}

		private int ResourceIdFromString(string p)
		{
			p = p.ToLower ().Replace (".png", "").Replace (".jpg", "");

			Type tipo = typeof(Resource.Drawable);

			return (int)tipo.GetFields().FirstOrDefault(n => n.Name.ToLower() == p).GetValue(null);
		}

		protected override void DispatchDraw (Android.Graphics.Canvas canvas)
		{
			base.DispatchDraw (canvas);

			var myNav = (RenderersEServices.CustomNavigationPage)this.Element;

			((Activity)Context).ActionBar.SetIcon (ResourceIdFromString (myNav.ImageName));
		}
	}
}

