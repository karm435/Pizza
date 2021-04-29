using LOR.Pizzerias.Domain;
using LOR.Pizzerias.Domain.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOR.Pizzeriass
{
	public class PizzaFactory
	{
		public static Pizza CreatePizza(PizzaTypes name)
		{
			Pizza pizza = name switch
			{
				PizzaTypes.Capriciosa => new CapriciosaPizza(),
				PizzaTypes.Florenza => new FlorenzaPizza(),
				PizzaTypes.Margherita => new MargheritaPizza(),
				PizzaTypes.Inferno => new InfernoPizza(),
				_ => null
			};

			return pizza;
		}
	}
}
