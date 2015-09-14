using System;

using Xamarin.Forms;
using System.Collections.Generic;

namespace MenuTeste
{
	public class MenuPage : ContentPage
	{
		public MenuListView Menu {
			get;
			set;
		}

		public MenuPage ()
		{
			Menu = new MenuListView ();

			Title = "itm";

			Content = new StackLayout () {
				Children = {
					Menu
				}
			};

			//this.Menu.ItemSelected += Menu_ItemSelected;
		}

	}

	/// <summary>
	/// Classe responsável por criar os itens do menu da master detail page
	/// </summary>
	public class MenuListView : ListView
	{
		public MenuListView ()
		{
			List<ItemMenu> items = this.CreateMenuItems ();
			//this.SeparatorColor = Color.Transparent;
			//this.SeparatorVisibility = SeparatorVisibility.None;
			ItemsSource = items;
			VerticalOptions = LayoutOptions.FillAndExpand;
			HorizontalOptions = LayoutOptions.CenterAndExpand;
			BackgroundColor = Color.Transparent;

			var cell = new DataTemplate (typeof(ImageCell));



			cell.SetBinding (TextCell.TextColorProperty, "TextColor");
			cell.SetBinding (TextCell.TextProperty, "DisplayText");
			cell.SetBinding (ImageCell.ImageSourceProperty, "DisplayImage");

			ItemTemplate = cell;
		}

		private List<ItemMenu> CreateMenuItems ()
		{
			List<ItemMenu> items = new List<ItemMenu> ();

			items.Add (new ItemMenu () {
				DisplayText = "Início",
				DisplayImage = "Icon-60.png",
				TextColor = Color.Black,
				Target = typeof(Content1)
			});



			return items;
		}
	}

	public class ListMenuItem
	{
		public List<ItemMenu> Itens{ get; set; }

		public string DisplayText {
			get;
			set;
		}
	}

	/// <summary>
	/// Classe responsável por armazenar o título, imagem e a página de detail do menu
	/// </summary>
	public class ItemMenu
	{
		public string DisplayText { get; set; }

		public string DisplayImage { get; set; }

		public Type Target { get; set; }

		public Color TextColor { get; set; }

	}
}


