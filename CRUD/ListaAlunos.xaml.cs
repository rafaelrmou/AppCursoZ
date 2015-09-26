using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace CRUD
{
	public partial class ListaAlunos : ContentPage
	{
		public ListaAlunos ()
		{
			InitializeComponent ();

			lstAluno.ItemsSource = App.dbRepo.List.Select (x => x.Nome);
		}
	}
}

