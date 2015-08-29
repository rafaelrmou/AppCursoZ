using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Paginas
{
	public partial class HomePage : ContentPage
	{
		public HomePage ()
		{
			InitializeComponent ();

			NavigationPage.SetHasBackButton (this, false);
		}

		protected override bool OnBackButtonPressed ()
		{

			/*DisplayAlert ("Sair", "Deseja fazer Logoff?", "Sim", "Não").ContinueWith (t => {
				return t.Result;
			});*/

			return true;


		}
	}
}

