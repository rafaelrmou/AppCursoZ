using System;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using RenderersEServices.Droid;

//[assembly: ExportRenderer(typeof(Button),typeof(MyButtonRenderer))]
namespace RenderersEServices.Droid
{
	public class MyButtonRenderer : ButtonRenderer
	{
		public MyButtonRenderer ()
		{
		}

		protected override void OnElementChanged (ElementChangedEventArgs<Button> e)
		{
			base.OnElementChanged (e);

			//this.Control.SetBackgroundColor (Android.Graphics.Color.Azure);


		}
	}
}

