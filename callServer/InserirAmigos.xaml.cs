using System;
using System.Collections.Generic;

using Xamarin.Forms;
using ViewModel;

namespace callServer
{
	public partial class InserirAmigos : ContentPage
	{
		public InserirAmigos ()
		{
			InitializeComponent ();

			BindingContext = new AmigoVM (this);

		}
	}
}

