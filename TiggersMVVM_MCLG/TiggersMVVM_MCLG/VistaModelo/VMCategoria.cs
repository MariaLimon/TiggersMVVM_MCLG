using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TrigersMVVM_MCLG.VistaModelo;
using Xamarin.Forms;
using TiggersMVVM_MCLG.Modelo;

namespace TiggersMVVM_MCLG.VistaModelo
{
	public class VMCategoria : BaseViewModel
	{
		
		#region VARIABLES
		string _Texto;
		ObservableCollection<Mcategorias> _listaCategorias;
		#endregion
		#region CONSTRUCTOR
		public VMCategoria(INavigation navigation)
		{
			Navigation = navigation;
			MostrarCategorias();
		}
		#endregion
		#region OBJETOS
		public ObservableCollection<Mcategorias> ListaCategorias
		{
			get { return _listaCategorias; }
			set { SetValue(ref _listaCategorias, value); }
		}
		#endregion
		#region PROCESOS
		public async Task ProcesoAsyncrono()
		{
			await DisplayAlert("Titulo", "Mensaje", "Ok");
		}
		public void MostrarCategorias()
		{
			ListaCategorias = new ObservableCollection<Mcategorias>(Datos.Dcategorias.MostrarCategorias());
		}
		#endregion
		#region COMANDOS
		public ICommand ProcesoAsyncommand => new Command(async () => await ProcesoAsyncrono());
		public ICommand ProcesoSimpcommand => new Command(MostrarCategorias);
		#endregion
	
	}
}
