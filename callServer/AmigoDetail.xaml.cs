﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace callServer
{
	public partial class AmigoDetail : ContentPage
	{
		public AmigoDetail (ViewModel.AmigoVM Atual)
		{
			InitializeComponent ();
			BindingContext = Atual;
		}
	}
}

