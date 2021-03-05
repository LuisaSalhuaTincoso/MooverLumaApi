using APIMooverLuma.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMooverLuma.Repositorio
{
	public  class UsuarioRepo
	{
		public static UsuarioPersona getUsuarioPersona(long id)
		{

			UsuarioPersona usuario = new UsuarioPersona
			{
				Nombre = "Carlos",
				ApePat = "Tapia Cornejo",
				RazonSocial = "Carlos Tapia Cornejo",
				Correo = "carlitoxtapia@gmail.com",
				Telefono = "930274827",
				Direccion = "Av. Francisco Mostajo 502",
				Documento = "73228518"
			};
			return usuario;
		}

		

	}
}
