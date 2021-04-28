using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LOR.Pizzeria.Tests
{
	public class PizzaFactoryTests
	{
		[Fact]
		public void ShouldCreateInfernoPizza()
		{
			var pizzaType = "Inferno";

			var pizza = PizzaFactory.CreatePizza(pizzaType);

			Assert.Equal(pizza.Name, pizzaType);
		}
	}
}
