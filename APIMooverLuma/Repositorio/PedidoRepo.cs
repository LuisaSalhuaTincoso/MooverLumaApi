using APIMooverLuma.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMooverLuma.Repositorio
{
	public class PedidoRepo
	{
		public static Pedido getPedido(long id) {


			Pedido pedido = new Pedido
			{
				Id = 5,
				Estado = "En camino",
				Fecharecojo = DateTime.Now,
				Fechaentrega = DateTime.Now,
				TelefonoEntrega = "930274827",
				DireccionEntrega = "Av.Polanco 409"

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
				Fecharecojo = DateTime.Now,
				Fechaentrega = DateTime.Now,
				TelefonoEntrega = "930274827",
				DireccionEntrega = "Av.Polanco 409"
			});
			pedidos.Add(new Pedido
			{
				Id = 2,
				Estado = "Pendiente",
				Fecharecojo = DateTime.Now,
				Fechaentrega = DateTime.Now,
				TelefonoEntrega = "9530274839",
				DireccionEntrega = "Av.Sucre 403 lT 3 "
			});
			pedidos.Add(new Pedido
			{
				Id = 3,
				Estado = "Finalizado",
				Fecharecojo = DateTime.Now,
				Fechaentrega = DateTime.Now,
				TelefonoEntrega = "930274827",
				DireccionEntrega = "Av.Polanco 409"
			});
			pedidos.Add(new Pedido
			{
				Id = 4,
				Estado = "Finalizado",
				Fecharecojo = DateTime.Now,
				Fechaentrega = DateTime.Now,
				TelefonoEntrega = "9530274839",
				DireccionEntrega = "Av.Sucre 403 lT 3 "
			});
			pedidos.Add(new Pedido
			{
				Id = 5,
				Estado = "Finalizado",
				Fecharecojo = DateTime.Now,
				Fechaentrega = DateTime.Now,
				TelefonoEntrega = "930274827",
				DireccionEntrega = "Av.Polanco 409"
			});
			pedidos.Add(new Pedido
			{
				Id = 6,
				Estado = "Finalizado",
				Fecharecojo = DateTime.Now,
				Fechaentrega = DateTime.Now,
				TelefonoEntrega = "9530274839",
				DireccionEntrega = "Av.Sucre 403 lT 3 "
			});
			return pedidos;

		}
	}
}
