using System;
using Xamarin.Forms;

namespace RenderersEServices
{
	public class CustomNavigationPage : NavigationPage
	{
		public string ImageName {
			get;
			set;
		}

		public CustomNavigationPage (string imageName) : base(){
			ImageName = imageName;
		}

		public CustomNavigationPage(Page root, string imageName) : base(root){
			ImageName = imageName;
		}
	}
}

