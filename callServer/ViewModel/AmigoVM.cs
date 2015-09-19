using System;
using System.ComponentModel;
using Model;
using Xamarin.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Windows.Input;
using System.Linq;

namespace ViewModel
{
	public class AmigoVM : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged implementation

		public event PropertyChangedEventHandler PropertyChanged;

		#endregion

		public virtual void OnPropertyChanged (string PropertyName)
		{
			if (PropertyChanged != null) {
				PropertyChanged (this, new PropertyChangedEventArgs (PropertyName));
			}
		}

		public AmigoModel AmigoModel {
			get;
			set;
		}

		public Page PaginaAtual {
			get;
			set;
		}

		public AmigoVM (Page Pagina)
		{
			AmigoModel = new AmigoModel ();
			PaginaAtual = Pagina;
		}

		public AmigoVM (AmigoModel model, Page Pagina)
		{
			AmigoModel = model;
			PaginaAtual = Pagina;
		}

		public async Task<List<AmigoVM>> GetAll ()
		{
			var list = await AmigoModel.GetAllFormServer ();

			var listaRtn = from X in list
				select new AmigoVM (X, PaginaAtual);

			return listaRtn.ToList ();
		}

		public ICommand SalverCmd {
			get { 
				return new Command (() => {
//					Device.BeginInvokeOnMainThread(()=>{
//						Acr.UserDialogs.UserDialogs.Instance.Loading("Carregando...");
//					});
					Save ().ContinueWith (t => {
						Device.BeginInvokeOnMainThread(()=>{
//							Acr.UserDialogs.UserDialogs.Instance.HideLoading();

							if(t.Result){

								//PaginaAtual.DisplayAlert("ok","ok","ok");
							}
							else{

								//PaginaAtual.DisplayAlert("nook","nook","nook");
							}
						});
					});
				});
			}
		}

		public async Task<bool> Save ()
		{

			var Salvo = await AmigoModel.Save ();

			return Salvo;

		}

		public string Nome {
			get { 
				if (AmigoModel.Nome == null)
					AmigoModel.Nome = "";

				return AmigoModel.Nome;
			}
			set { 
				if (AmigoModel.Nome != value) {
					AmigoModel.Nome = value;
					OnPropertyChanged ("Nome");
				}
			}
		}

		public int Identificador {
			get { 
				if (AmigoModel.ID == null)
					AmigoModel.ID = 0;

				return AmigoModel.ID;
			}
			set { 
				if (AmigoModel.ID != value) {
					AmigoModel.ID = value;
					OnPropertyChanged ("Identificador");
				}
			}
		}

		public string Telefone {
			get { 
				if (AmigoModel.NR_TELEFONE == null)
					AmigoModel.NR_TELEFONE = "";

				return AmigoModel.NR_TELEFONE;
			}
			set { 
				if (AmigoModel.NR_TELEFONE != value) {
					AmigoModel.NR_TELEFONE = value;
					OnPropertyChanged ("Telefone");
				}
			}
		}

		public DateTime DataNascimento {
			get { 
				if (AmigoModel.DT_NASCIMENTO == null)
					AmigoModel.DT_NASCIMENTO = DateTime.Now;

				return AmigoModel.DT_NASCIMENTO;
			}
			set { 
				if (AmigoModel.DT_NASCIMENTO != value) {
					AmigoModel.DT_NASCIMENTO = value;
					OnPropertyChanged ("DataNascimento");
				}
			}
		}

		public string Email {
			get { 
				if (AmigoModel.DS_EMAIL == null)
					AmigoModel.DS_EMAIL = "";

				return AmigoModel.DS_EMAIL;
			}
			set { 
				if (AmigoModel.DS_EMAIL != value) {
					AmigoModel.DS_EMAIL = value;
					OnPropertyChanged ("Email");
				}
			}
		}
	} 
}

