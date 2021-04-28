using System;
using System.Collections.Generic;
using System.Text;

namespace LOR.Pizzeria.Domain
{
	class SydneyPizzeria : IPizzeria
	{
		public string Location => throw new NotImplementedException();

		public IEnumerable<IMenu> Menu => throw new NotImplementedException();

		public void PrintReceipt()
		{
			throw new NotImplementedException();
		}
	}
}
