using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIMooverLuma.Entidades;
using APIMooverLuma.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace APIMooverLuma.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UsuarioController : ControllerBase
	{
		// GET api/values
		[HttpGet]
		public ActionResult<IEnumerable<string>> Get()
		{
			return new string[] { "value1", "value2" };
		}

		// GET api/values/5
		[HttpGet("{id}")]
		public  UsuarioPersona Get(int id)
			
		{
		   return UsuarioRepo.getUsuarioPersona(id);
		}

		// POST api/values
		[HttpPost]
		public void Post([FromBody] string value)
		{
		}

		// PUT api/values/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/values/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{

		}


	}
}
