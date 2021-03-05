using APIMooverLuma.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMooverLuma.Repositorio
{
	public class PedidoRepo
	{
		public static PedidoDetalle getPedido(long id) {


			PedidoDetalle pedido = new PedidoDetalle
			{
				Id = 5,
				Estado = "Finalizado",
				Fecharecojo = "21/01/18 13:30",
				Fechaentrega = "21/01/18 16:30",
				TelefonoEntrega = "930474787",
				DireccionEntrega = "Av.Ricardo Palma 890",
				DireccionRecojo = "Calle 1 Ovalo Alameda",
				NombreEmisor= "Carlos Tapia",
				NombreReceptor ="Tatiana Lauro",
				TelefonoRecojo ="96258413",
				Categoria = "Muebles",
				Peso = "15kg",
				Vehiculo = "Auto",
				ReferenciaEntrega = "Posta medica A.S.A dos cuadra arriba",
				Costo = "12.00"

				

			};
			return pedido;

		}

		public static List<Pedido> getPedidos(long idUsuario)
		{
			List<Pedido> pedidos = new List<Pedido>();
			pedidos.Add(new Pedido
			{
				Id = 1,
				Estado = "En camino",
				Fecharecojo = "21/03/05 13:30",
				Fechaentrega = "21/03/05 13:30",
				TelefonoEntrega = "930274827",
				DireccionEntrega = "Av.Polanco 409",
				Receptor = "Diego Chara"
			});
			pedidos.Add(new Pedido
			{
				Id = 2,
				Estado = "Cancelado",
				Fecharecojo = "21/02/14 13:30",
				Fechaentrega = "",
				TelefonoEntrega = "9530274839",
				DireccionEntrega = "Av.Sucre 403 lT 3 ",
				Receptor = "Jose Yarleque"
			});
			pedidos.Add(new Pedido
			{
				Id = 3,
				Estado = "Finalizado",
				Fecharecojo = "21/01/18 13:30",
				Fechaentrega = "21/01/18 13:30",
				TelefonoEntrega = "930274827",
				DireccionEntrega = "Av.Polanco 409",
				Receptor = "Ana Fuente Larco"
			});
			pedidos.Add(new Pedido
			{
				Id = 4,
				Estado = "Finalizado",
				Fecharecojo = "21/01/18 13:30",
				Fechaentrega = "21/01/18 13:30",
				TelefonoEntrega = "9530274839",
				DireccionEntrega = "Av.Sucre 403 lT 3 ",
				Receptor = "Sandra Ramirez"
			});
			pedidos.Add(new Pedido
			{
				Id = 5,
				Estado = "Finalizado",
				Fecharecojo = "21/01/18 13:30",
				Fechaentrega = "21/01/18 13:30",
				TelefonoEntrega = "930274827",
				DireccionEntrega = "Av.Polanco 409",
				Receptor = "Ricardo Arjona"
			});
			pedidos.Add(new Pedido
			{
				Id = 6,
				Estado = "Finalizado",
				Fecharecojo = "21/01/18 13:30",
				Fechaentrega = "21/01/18 13:30",
				TelefonoEntrega = "9530274839",
				DireccionEntrega = "Av.Sucre 403 lT 3 "
			});
			return pedidos;

		}
	}
}
