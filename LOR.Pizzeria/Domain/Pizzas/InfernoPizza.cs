using System;
using System.Collections.Generic;
using System.Text;

namespace LOR.Pizzerias.Domain.Pizzas
{
	public class InfernoPizza : Pizza
	{
		public override List<string> Ingredients => new() { "chili peppers", "mozzarella", "chicken", "cheese" };

		public override string Name => "Inferno";

		
	}
}
