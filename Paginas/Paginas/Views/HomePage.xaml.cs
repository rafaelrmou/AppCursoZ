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

		void openAbas_Clicked(object sender, EventArgs e){
			
			Navigation.PushModalAsync (new Abas());
		}

		protected override bool OnBackButtonPressed ()
		{
			/*DisplayAlert ("Sair", "Deseja fazer Logoff?", "Sim", "Não").ContinueWith (t => {
				return t.Result;
			});*/
			Sair ();
			return true;
		}

		public async void Sair(){
			//Limpar a baseDados ou cache ou Sessão
			await DisplayAlert ("Sair", "Deseja fazer Logoff?", "Sim", "Não").ContinueWith (t => {
				if(t.Result){
					Device.BeginInvokeOnMainThread(() =>
						{
							Navigation.PopAsync();	
						});
				}
			});

		}
	}
}

