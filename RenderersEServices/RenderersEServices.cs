using System;

using Xamarin.Forms;

namespace RenderersEServices
{
	public class App : Application
	{
		public App ()
		{
			// The root page of your application
			MainPage = new CustomNavigationPage (
				new ContentPage () {
					Content = new Label (){ Text = "Icone Star" }
				}, 
				"star.png");

			DependencyService.Get<IFalar> ().Conversar ("Olá Alunos da Zarb Solutions");
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

