using LOR.Pizzerias.Domain.Pizzas;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using LOR.Pizzerias.Domain.Toppings;

namespace LOR.Pizzerias.Domain
{
	public class BrisbanePizzeria : Pizzeria
	{
		private IMenu _menu;

		public BrisbanePizzeria()
		{
			_menu = new BrisbanePizzeriaMenu();
		}
		public override string Location => "Brisbane";

		public override IMenu Menu => _menu;

	}

	public class BrisbanePizzeriaMenu : IMenu
	{
		public IEnumerable<Pizza> Pizzas => new List<Pizza>()
		{
			new CapriciosaPizza(),
			new FlorenzaPizza(),
			new MargheritaPizza()
		};

		public IEnumerable<ToppingType> ToppingsAvailable => new List<ToppingType>()
		{
			ToppingType.BlackOlives,
			ToppingType.Pineapple
		};

		public IDictionary<string, decimal> PizzaPrices => new Dictionary<string, decimal>()
		{
			{"Capriciosa", 20.00m }, // TODO: Use PizzaType enum
			{"Florenza", 21.00m },
			{"Margherita", 22.00m }
		};

		public IDictionary<ToppingType, decimal> ToppingsPrices => new Dictionary<ToppingType, decimal>()
		{
			{ ToppingType.BlackOlives, 1.5m },
			{ ToppingType.Pineapple, 2.0m }
		};
	}
}
