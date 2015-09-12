using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ListaApp
{
	public partial class PickerPage : ContentPage
	{
		public CustomPicker<Aluno> pck {
			get;
			set;
		}

		public PickerPage ()
		{
			InitializeComponent ();


			pck = new CustomPicker<Aluno> ();
			pck.Title = "Text";
			pck.ObjList = new List<Aluno> () { 
				new Aluno () {
					ID = 1,
					Bairro = "ABC",
					Value = "Rafael"
				},
				new Aluno () {
					ID = 2,
					Bairro = "ABC",
					Value = "Braz - Soldado perdido"
				},
				new Aluno () {
					ID = 3,
					Bairro = "ABC",
					Value = "Zézé da Feira"
				},
			};

			pck.SelectedIndexChanged += Pck_SelectedIndexChanged;
			pck.BackgroundColor = Color.Red;
			Content = pck;

//			pck.Cu
		}

		void Pck_SelectedIndexChanged (object sender, EventArgs e)
		{
			pck.CustomSelect (sender, e);
		}
	}

	public class Aluno : BaseModelPicker
	{
		public int ID {
			get;
			set;
		}

		public string Bairro {
			get;
			set;
		}
	}

	public class CustomPicker<T> : Picker where T : BaseModelPicker
	{

		private List<T> _objList;

		public List<T> ObjList {
			get { 
				if (_objList == null)
					_objList = new List<T> ();

				return _objList;
			}
			set { 
				_objList = value;
				PopularPicker ();
			}
		}

		public T CurrentItem {
			get;
			set;
		}

		public void PopularPicker ()
		{
			this.Items.Clear ();

			foreach (var item in ObjList) {
				this.Items.Add (item.Value);
			}
		}

		public void CustomSelect (object sender, EventArgs e)
		{

			CurrentItem = ObjList [this.SelectedIndex];

		}



	}

	public class BaseModelPicker
	{
		
		public string Value {
			get;
			set;
		}

	}
}

