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
			BindingContext = ViewModel.GetAll ();
		}
	}
}

