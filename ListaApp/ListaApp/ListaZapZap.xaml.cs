using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.ComponentModel;

namespace ListaApp
{
	public class myModel : INotifyPropertyChanged{
		private List<FeedDTO> _listaDTO;
		public List<FeedDTO> listaDTO {
			get { 
				if (_listaDTO == null) {
					_listaDTO = new List<FeedDTO> ();
				}
				return _listaDTO;
			}
			set { 
				//if (_listaDTO != value) {
					_listaDTO = value;
					OnPropertyChanged ("listaDTO");
				//}
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public virtual void OnPropertyChanged(string PropertyName){
			if (PropertyChanged != null) {
				PropertyChanged (this, new PropertyChangedEventArgs (PropertyName));
			}
		}
	}
	public partial class ListaZapZap : ContentPage
	{
		public myModel VM {
			get;
			set;
		}

			

		public ListaZapZap ()
		{
			InitializeComponent ();

			//lstFeed.ItemsSource = new string[]{ "", "", "" };

			lstFeed.SeparatorColor = Color.Transparent;
			lstFeed.SeparatorVisibility = SeparatorVisibility.None;
			lstFeed.IsPullToRefreshEnabled = true;

			lstFeed.Refreshing += LstFeed_Refreshing;

			lstFeed.ItemSelected += LstFeed_ItemSelected;

			VM = new myModel ();

			for (int i = 0; i < 10; i++) {
				VM.listaDTO.Add (new FeedDTO () { 
					Nome = "Item " + i,
					Quando = string.Format ("{0}h atrás", i),
					Texto = "hfadhfashdfs sdh faklsdhf asdf kljasdfkds kfhads kfadhskjf adskjfa sdhfa sdkghfak sdfaldsfaiudsg asd",
					CanComment = i % 2 == 0,
					CanLike = i % 2 != 0,
					CanShare = true
				});
			}

			BindingContext = VM;
		}

		void LstFeed_ItemSelected (object sender, SelectedItemChangedEventArgs e)
		{
			var sl = e.SelectedItem as FeedDTO;

			DisplayAlert ("Teste", sl.Nome, "ok");
		}

		void LstFeed_Refreshing (object sender, EventArgs e)
		{
			var m = VM.listaDTO;
			m.Add (new FeedDTO () { 
				Nome = "Item Atualizado",
				Quando = string.Format ("Agora"),
				Texto = "Dado Atualizado as " + DateTime.Now,
				CanComment = true,
				CanLike = true,
				CanShare = true
			});	

			VM.listaDTO = m;

			//lstFeed.IsRefreshing = false;

			lstFeed.ItemsSource = VM.listaDTO;


		}
	}
}

