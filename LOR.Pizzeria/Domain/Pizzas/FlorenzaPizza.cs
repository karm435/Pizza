using LOR.Pizzerias.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace LOR.Pizzerias.Domain.Pizzas
{
	public class FlorenzaPizza : Pizza
	{
		public override List<string> Ingredients => new List<string> { "olives", "pastrami", "mozarella", "onion" };

		public override string Name => "Florenza";

		
		public override void Cut()
		{
			Console.WriteLine("Cutting pizza into 6 slices with a special knife...");
		}
	}
}
