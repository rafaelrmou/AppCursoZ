using System;

using Xamarin.Forms;

namespace ListaApp
{
	public class NomeTamplate : StackLayout
	{
		public NomeTamplate ()
		{
			var lbl = new Label ();
			lbl.TextColor = Color.Blue;

			var context = this.BindingContext as String;

			lbl.SetBinding(Label.TextProperty,context);

			Children.Add (lbl);
		}
	}
	public class App : Application
	{
		public App ()
		{
			// The root page of your application
			MainPage = new PickerPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

