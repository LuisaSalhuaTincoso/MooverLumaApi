using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMooverLuma.Entidades
{
	public class UsuarioPersona
	{
			
			public int IdTipoDocumento { get; set; }
			public string IdUbigeo { get; set; }
			public string Documento { get; set; }
			public string RazonSocial { get; set; }
			public string Nombre { get; set; }
			public string ApePat { get; set; }
			public string ApeMat { get; set; }
			public string Correo { get; set; }
			public string Telefono { get; set; }
			public string Direccion { get; set; }
			public string TipoDocumentoDesc { get; set; }
		
	}
}
