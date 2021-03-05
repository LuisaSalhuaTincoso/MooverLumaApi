using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIMooverLuma.Entidades;
using APIMooverLuma.Repositorio;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIMooverLuma.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PedidoController : Controller
	{
				// GET: /<controller>/

		[HttpGet("{id}")]
		public PedidoDetalle Get(long id)

		{
			 return PedidoRepo.getPedido(id);
		}

		[HttpGet()]
		public List<Pedido> GetPedidos(long idUsuario)

		{
			//var enumerable = new {  };
			 return PedidoRepo.getPedidos(idUsuario);
		}


	}
}
