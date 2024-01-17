using System;
using TiggersMVVM_MCLG.Vistas;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TiggersMVVM_MCLG
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new Categoria();
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
