using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TiggersMVVM_MCLG.Modelo;

namespace TiggersMVVM_MCLG.Datos
{
	public class Dcategorias
	{
		public static ObservableCollection<Mcategorias> MostrarCategorias()
		{
			return new ObservableCollection<Mcategorias>()
			{
				new Mcategorias()
				{
					descripcion = "Cena",
					numeroItem = 4512,
					imagen = "https://i.ibb.co/s17mmcX/cena.png",
					backgroundColor = "#EAEDF6",
					textColor = "#000000"
				},
				new Mcategorias()
				{
					descripcion = "Hotel",
					numeroItem = 4512,
					imagen = "https://i.ibb.co/sQmmxnc/hotel.png",
					backgroundColor = "#EAEDF6",
					textColor = "#000000"
				},
				new Mcategorias()
				{
					descripcion = "Fiesta",
					numeroItem = 4512,
					imagen = "https://i.ibb.co/M8V6v0Z/papel-picado.png",
					backgroundColor = "#EAEDF6",
					textColor = "#000000"
				},
				new Mcategorias()
				{
					descripcion = "Flores",
					numeroItem = 4512,
					imagen = "https://i.ibb.co/NN3fY1J/maceta.png",
					backgroundColor = "#EAEDF6",
					textColor = "#000000"
				},
			};
		}
	}
}
