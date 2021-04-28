using LOR.Pizzeria.Domain;
using LOR.Pizzeria.Domain.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOR.Pizzeria
{
	public class PizzaFactory
	{
		public static IPizza CreatePizza(string name)
		{
			return name switch
			{
				"Capriciosa" => new CapriciosaPizza(),
				"Florenza" => new FlorenzaPizza(),
				"Margherita" => new MargheritaPizza(),
				"Inferno" => new InfernoPizza(),
				_ => null
			};
		}
	}
}
