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
		public static Pizza CreatePizza(string name)
		{

			Pizza pizza = name switch
			{
				"Capriciosa" => new CapriciosaPizza(),
				"Florenza" => new FlorenzaPizza(),
				"Margherita" => new MargheritaPizza(),
				"Inferno" => new InfernoPizza(),
				_ => null
			};

			return pizza;
		}
	}
}
