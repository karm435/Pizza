using System;
using System.Collections.Generic;
using System.Text;

namespace LOR.Pizzerias.Domain.Pizzas
{
	public class MargheritaPizza : Pizza
	{
		public override List<string> Ingredients => new List<string> { "mozarella", "onion", "garlic", "oregano" };

		public override string Name => "Margherita";

		public override void Bake()
		{
			Console.WriteLine("Baking pizza for 15 minutes at 200 degrees...");
		}
	}
}
