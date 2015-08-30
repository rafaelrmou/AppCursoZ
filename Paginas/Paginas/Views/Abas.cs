using System;

using Xamarin.Forms;

namespace Paginas
{
	public class Abas : CarouselPage
	{
		public Abas ()
		{
			Children.Add (new Passo1());
			Children.Add (new Passo2());
			Children.Add (new Passo3());

			NavegarPara (1);
		}

		protected override void OnCurrentPageChanged ()
		{
			base.OnCurrentPageChanged ();

			if (CurrentPage == Children [0]) {
				NavegarPara (1);
				//Nao quero
			} else if (CurrentPage == Children [2]) {
				NavegarPara (1);
				//Quero
			} else {
			//Load Data
			}
		}

		protected override bool OnBackButtonPressed ()
		{
			return true;
		}

		public void NavegarPara(int element){
			CurrentPage = Children[element];
		}


	}
}


