using LOR.Pizzerias.Domain.Pizzas;
using System;
using System.Collections.Generic;
using System.Text;

namespace LOR.Pizzerias.Domain
{
	public class BrisbanePizzeria : Pizzeria
	{
		public override string Location => "Brisbane";

		public override IMenu Menu => new BrisbanePizzeriaMenu();


		public override void PrintReceipt(Pizza[] forOrderedPizzas)
		{
			throw new NotImplementedException();
		}

		public BrisbanePizzeria()
		{
			
		}
	}

	public class BrisbanePizzeriaMenu : IMenu
	{
		public IEnumerable<Pizza> Pizzas => new List<Pizza>()
		{
			new CapriciosaPizza(),
			new FlorenzaPizza(),
			new MargheritaPizza()
		};

		public IEnumerable<ITopping> Toppings => throw new NotImplementedException();

		public IDictionary<string, decimal> PizzaPrices => throw new NotImplementedException();

	}
}
