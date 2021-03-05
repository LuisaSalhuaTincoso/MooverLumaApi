using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMooverLuma.Entidades
{
	public class PedidoDetalle
	{
		public long Id { get; set; }
		public string Estado { get; set; }
		public string TelefonoRecojo { get; set; }
		public string DireccionRecojo { get; set; }
		public string Fecharecojo { get; set; }
		public string Fechaentrega { get; set; }
		public string TelefonoEntrega { get; set; }
		public string DireccionEntrega { get; set; }
		public string NombreEmisor { get; set; }
		public string NombreReceptor { get; set; }
		public string Peso { get; set; }
		public string Categoria { get; set; }
		public string Vehiculo { get; set; }
		public string Costo { get; set; }
		public string ReferenciaEntrega { get; set; }
		public string ReferenciaRecojo { get; set; }



		}
}
