using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Paginas
{
	public partial class Passo1 : ContentPage
	{
		public Button GoToNextIndex {
			get;
			set;
		}

		public EntryCell Nome {
			get;
			set;
		}

		public EntryCell Sobrenome {
			get;
			set;
		}

		public Passo1 ()
		{
			InitializeComponent ();
			GoToNextIndex = new Button ();
			GoToNextIndex.Text = "Ir para Aba 2";
			GoToNextIndex.Clicked += GoToNextIndex_Clicked;
			Nome = new EntryCell ();
			Nome.Label = "Nome";
			Sobrenome = new EntryCell ();

			Content = new StackLayout () { 
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
				Children = {
					new TableView (new TableRoot () {
						new TableSection () {
							Nome,
							Sobrenome,
							new ViewCell(){
								View = new DatePicker()
							}, new SwitchCell(){Text="Notificação"}
						},
					}) {
						Intent = TableIntent.Settings
					},
					GoToNextIndex
				}
			};
		}

		void GoToNextIndex_Clicked (object sender, EventArgs e)
		{
			var aba = Parent as Abas;
			aba.NavegarPara (1);
		}
	}
}

