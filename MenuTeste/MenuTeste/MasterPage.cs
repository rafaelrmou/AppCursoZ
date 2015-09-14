using System;

using Xamarin.Forms;

namespace MenuTeste
{
	public class MasterPage : MasterDetailPage
	{
		public MasterPage ()
		{
			Title = "menu";
			var menu = new MenuPage ();

			menu.Menu.ItemSelected += Menu_Menu_ItemSelected;

			Master = menu;

			Detail = new NavigationPage (new ContentPage () {
				Title = "Default", 
				Content = new Label () { 
					Text = "Default Page"
				}
			});
		}

		void Menu_Menu_ItemSelected (object sender, SelectedItemChangedEventArgs e)
		{
			if (e.SelectedItem == null)
				return;

			var menuS = (e.SelectedItem as ItemMenu).Target;
			var nextPage = (Page)Activator.CreateInstance (menuS);
			Detail = new NavigationPage (nextPage);

			IsPresented = false;

			(sender as ListView).SelectedItem = null;
		}
	}
}


