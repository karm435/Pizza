using LOR.Pizzerias.Domain;
using LOR.Pizzerias.Domain.Toppings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOR.Pizzerias
{
	public class ToppingsFactory
	{
		public static ITopping CreateTopping(ToppingType type)
		{
			return type switch
			{
				ToppingType.BlackOlives => new BlackOlives(),
				ToppingType.Pineapple => new Pineapple(),
				_ => null
			};
		}
	}
}
