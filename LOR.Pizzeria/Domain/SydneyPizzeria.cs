using LOR.Pizzerias.Domain.Pizzas;
using LOR.Pizzerias.Domain.Toppings;
using System;
using System.Collections.Generic;
using System.Text;

namespace LOR.Pizzerias.Domain
{
	class SydneyPizzeria : Pizzeria
	{
		private IMenu _menu;
		public SydneyPizzeria()
		{
			_menu = new SydneyPizzeriaMenu();
		}
		public override string Location => "Sydney";

		public override IMenu Menu => _menu;
	}

	public class SydneyPizzeriaMenu : IMenu
	{
		public IEnumerable<Pizza> Pizzas => new List<Pizza>()
		{
			new CapriciosaPizza(),
			new InfernoPizza()
		};
		public IEnumerable<ToppingType> ToppingsAvailable => new List<ToppingType>()
		{
			ToppingType.BlackOlives,
			ToppingType.Pineapple
		};

		public IDictionary<string, decimal> PizzaPrices => new Dictionary<string, decimal>()
		{
			{"Capriciosa", 30.00m }, // TODO: Use PizzaType enum
			{"Inferno", 31.00m }
		};

		public IDictionary<ToppingType, decimal> ToppingsPrices => new Dictionary<ToppingType, decimal>()
		{
			{ ToppingType.BlackOlives, 2.5m },
			{ ToppingType.Pineapple, 1.0m }
		};
	}
}
