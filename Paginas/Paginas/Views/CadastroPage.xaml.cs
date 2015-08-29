using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Paginas
{
	public partial class CadastroPage : ContentPage
	{

		private StackLayout _Layout;

		public StackLayout Layout {
			get{
				if (_Layout == null)
					_Layout = new StackLayout ();

				return _Layout;
			}
			set{
				if (_Layout != value) {
					_Layout = value;
				}
			}
		}

		public Entry LoginEntry {
			get;
			set;
		}

		public Entry SenhaEntry {
			get;
			set;
		}

		public Entry NomeEntry {
			get;
			set;
		}

		public Button CriarConta {
			get;
			set;
		}
		
		public CadastroPage ()
		{
			InitializeComponent ();

			Layout = new StackLayout ()
			{
				
			};

			LoginEntry = new Entry (){
				Placeholder = "Login"
			};
			SenhaEntry = new Entry (){
				Placeholder = "Senha",
				IsPassword = true
			};
			NomeEntry = new Entry (){
				Placeholder = "Nome"
			};
			CriarConta = new Button (){
				Text = "Criar Conta"
			};

			Layout.Children.Add (NomeEntry);
			Layout.Children.Add (LoginEntry);
			Layout.Children.Add (SenhaEntry);
			Layout.Children.Add (CriarConta);

			CriarConta.Clicked+= CriarConta_Clicked;

			Content = Layout;
		}

		async void CriarConta_Clicked (object sender, EventArgs e)
		{
			//Apos Inserir no banco
			await DisplayAlert("Sucesso","Sua conta foi criada","Ok");
			Navigation.PopAsync ();
		}
	}
}

