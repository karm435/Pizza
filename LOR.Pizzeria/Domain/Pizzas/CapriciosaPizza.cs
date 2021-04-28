using System;
using System.Collections.Generic;
using System.Text;

namespace LOR.Pizzerias.Domain.Pizzas
{
	public class CapriciosaPizza : Pizza
	{
		public override List<string> Ingredients => new List<string> { "mushrooms", "cheese", "ham", "mozarella" };

		public override string Name => "Capriciosa";
	}
}
