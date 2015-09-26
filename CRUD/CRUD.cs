using System;

using Xamarin.Forms;
using SQLite.Net.Interop;

namespace CRUD
{
	public class App : Application
	{
		public static DataBaseRepository dbRepo {
			get;
			set;
		}
		public App ()
		{
			// The root page of your application
			MainPage = new NavigationPage(new InsereAlunos());
		}

		public App (string dataBaseName, ISQLitePlatform sqlitePltf) : this ()
		{
			dbRepo = new DataBaseRepository(sqlitePltf, dataBaseName);
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

