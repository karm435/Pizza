using LOR.Pizzerias.Domain.Pizzas;
using System;
using System.Collections.Generic;
using System.Text;

namespace LOR.Pizzerias.Domain
{
	class SydneyPizzeria : Pizzeria
	{

		public override string Location => throw new NotImplementedException();


		public override IMenu Menu => throw new NotImplementedException();

		public override void PrintReceipt(Pizza[] forOrderedPizzas)
		{
			throw new NotImplementedException();
		}
	}
}
