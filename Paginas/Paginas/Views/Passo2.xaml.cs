using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Paginas
{
	public partial class Passo2 : ContentPage
	{
		public Passo2 ()
		{
			InitializeComponent ();
			Title = "Aba 2";

			Content = new WebView (){ 
				Source = new UrlWebViewSource(){
					Url = "www.google.com"
				},
				
			};
		}
	}
}

