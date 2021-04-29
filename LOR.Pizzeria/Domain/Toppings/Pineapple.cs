using System;
using System.Collections.Generic;
using System.Text;

namespace LOR.Pizzerias.Domain.Toppings
{
	public class Pineapple : ITopping
	{
		public ToppingType Type => ToppingType.Pineapple;

		public decimal Quantity { get; set; }

		public decimal Price => 2.0m;
	}
}
