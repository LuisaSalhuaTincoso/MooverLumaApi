﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMooverLuma.Entidades
{
	public class Pedido
	{
		public long Id { get; set; }
		public string Estado { get; set; }
		public string Fecharecojo { get; set; }
		public string Fechaentrega { get; set; }
		public string TelefonoEntrega { get; set; }
		public string DireccionEntrega { get; set; }
		public string Receptor { get; set; }
	}
}
