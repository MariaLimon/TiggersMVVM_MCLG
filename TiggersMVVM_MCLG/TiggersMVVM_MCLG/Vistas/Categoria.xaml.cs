using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiggersMVVM_MCLG.VistaModelo;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TiggersMVVM_MCLG.Vistas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Categoria : ContentPage
	{
		public Categoria()
		{
			InitializeComponent();
			BindingContext = new VMCategoria(Navigation);
		}
	}
}