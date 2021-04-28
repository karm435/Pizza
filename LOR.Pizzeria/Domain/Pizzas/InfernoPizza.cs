using System;
using System.Collections.Generic;
using System.Text;

namespace LOR.Pizzeria.Domain.Pizzas
{
	public class InfernoPizza : IPizza
	{
		public List<string> Ingredients { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public void Bake()
		{
			throw new NotImplementedException();
		}

		public void Box()
		{
			throw new NotImplementedException();
		}

		public void Cut()
		{
			throw new NotImplementedException();
		}

		public void Prepare()
		{
			throw new NotImplementedException();
		}
	}
}
