using System;
using System.Collections.Generic;
using System.Text;

namespace LOR.Pizzerias.Domain.Toppings
{
	public class BlackOlives : ITopping
	{
		public ToppingType Type => ToppingType.BlackOlives;

	
		public decimal Quantity { get; set; }

		public decimal Price => 1.5m;
	}
}
