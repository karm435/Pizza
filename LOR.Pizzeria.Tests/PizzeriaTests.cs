using LOR.Pizzerias.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LOR.Pizzerias.Tests
{
	public class PizzeriaTests
	{
		[Fact]
		public void ShouldNotBakePizzaWhichIsNotAvailable()
		{
			var pizzaType = "PizzaNotFound";

			var store = new BrisbanePizzeria();

			var orderedPizza = store.Order(pizzaType);

			Assert.Null(orderedPizza);
		}

		[Fact]
		public void ShouldBakePizzaWhichIsAvailable()
		{
			var pizzaType = "Capriciosa";

			var store = new BrisbanePizzeria();

			var orderedPizza = store.Order(pizzaType);

			Assert.NotNull(orderedPizza);
		}
	}
}
