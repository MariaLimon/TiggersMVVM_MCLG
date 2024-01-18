using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TrigersMVVM_MCLG.VistaModelo;
using Xamarin.Forms;
using TiggersMVVM_MCLG.Modelo;
using Xamarin.Forms.Internals;
using System.Linq;

namespace TiggersMVVM_MCLG.VistaModelo
{
	public class VMCategoria : BaseViewModel
	{
		
		#region VARIABLES
		string _Texto;
		bool _activadorAnimacionImg;
		string _imagen;
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
        public bool ActivadorAnimacionImg
        {
            get { return _activadorAnimacionImg; }
            set { SetValue(ref _activadorAnimacionImg, value); }
        }
        public string Imagen
        {
            get { return _imagen; }
            set { SetValue(ref _imagen, value); }
        }
        #endregion
        #region PROCESOS
        public void Seleccionar(Mcategorias modelo)
        {
			var index = ListaCategorias
				.ToList()
				.FindIndex(p => p.descripcion == modelo.descripcion);
			Imagen = modelo.imagen;
			if (index > -1)
			{
				Deseleccionar();
				ActivadorAnimacionImg = true;
				ListaCategorias[index].selected = true;
				ListaCategorias[index].textColor = "#FFFFFF";
				ListaCategorias[index].backgroundColor = "#FF506B";
			}
        }
        public void Deseleccionar()
		{
			ListaCategorias.ForEach((item) =>
			{
				ActivadorAnimacionImg = false;
				item.selected = false;
				item.textColor = "#000000";
				item.backgroundColor = "#EAEDF6";
			});
		}
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
        public ICommand ProcesoSimpSeleccionar => new Command<Mcategorias>((p)=> Seleccionar(p));

        #endregion

    }
}
