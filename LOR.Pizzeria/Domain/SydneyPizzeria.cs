using LOR.Pizzerias.Domain.Pizzas;
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
		public IEnumerable<ITopping> Toppings => throw new NotImplementedException();

		public IDictionary<string, decimal> PizzaPrices => new Dictionary<string, decimal>()
		{
			{"Capriciosa", 30.00m }, // TODO: Use PizzaType enum
			{"Inferno", 31.00m }
		};
	}
}
