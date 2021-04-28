using System;
using System.Collections.Generic;
using System.Text;

namespace LOR.Pizzeria.Domain
{
	public class BrisbanePizzeria : IPizzeria
	{
		public string Location => "Brisbane";

		public IEnumerable<IMenu> Menu => throw new NotImplementedException();

		public void PrintReceipt()
		{
			throw new NotImplementedException();
		}

		public BrisbanePizzeria()
		{
			
		}
	}

	public class BrisbanePizzeriaMenu : IMenu
	{
		public IEnumerable<IPizza> Pizzas => throw new NotImplementedException();

		public IEnumerable<ITopping> Toppings => throw new NotImplementedException();

		public IDictionary<ITopping, decimal> ToppingsPrices => throw new NotImplementedException();

		public IDictionary<IPizza, decimal> PizzaPrices => throw new NotImplementedException();
	}
}
