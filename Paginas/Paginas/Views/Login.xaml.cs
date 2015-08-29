using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Paginas
{
	public partial class Login : ContentPage
	{
		public Login ()
		{
			InitializeComponent ();

			NavigationPage.SetHasNavigationBar (this, false);

		}

		public void Login_Clicked(object sender, EventArgs e){
			Navigation.PushAsync (new HomePage ());
		}

		public void Cadastro_Clicked(object sender, EventArgs e){
			Navigation.PushAsync (new CadastroPage ());
		}
	}
}

