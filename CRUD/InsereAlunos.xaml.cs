using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CRUD
{
	public partial class InsereAlunos : ContentPage
	{
		public InsereAlunos ()
		{
			InitializeComponent ();
		}

		void btn_Clicked(object sender, EventArgs e){
		
			App.dbRepo.Add (new Aluno (){
				Nome = entr_Nome.Text
			});

			DisplayAlert ("Message", App.dbRepo.Mensage, "OK");
		}
		void btn2_Clicked(object sender, EventArgs e){
			Navigation.PushModalAsync (new ListaAlunos ());
		}
	}
}

