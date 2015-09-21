using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace callServer
{
	public partial class ListAmigos : ContentPage
	{
		public ViewModel.AmigoVM ViewModel {
			get;
			set;
		}
		public ListAmigos ()
		{
			InitializeComponent ();
			ViewModel = new ViewModel.AmigoVM (this);
			Carregar ();
			ToolbarItems.Add(new ToolbarItem("Add","Icon-60.png",()=>{
				Navigation.PushAsync (new InserirAmigos());
			}));
		}

		async void Carregar(){
			Lista.ItemsSource = await ViewModel.GetAll ();
			Lista.ItemSelected += Lista_ItemSelected;
		}

		void Lista_ItemSelected (object sender, SelectedItemChangedEventArgs e)
		{
			Navigation.PushAsync (new AmigoDetail (e.SelectedItem as ViewModel.AmigoVM));
		}
	}
}

