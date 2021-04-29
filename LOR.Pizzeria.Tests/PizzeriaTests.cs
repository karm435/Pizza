using LOR.Pizzerias.Domain;
using LOR.Pizzerias.Domain.Pizzas;
using LOR.Pizzerias.Domain.Toppings;
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
		public void ShouldBakePizzaWhichIsAvailable()
		{
			var pizzaType = PizzaTypes.Capriciosa;

			var store = new BrisbanePizzeria();

			var orderedPizza = store.Order(pizzaType);

			Assert.NotNull(orderedPizza);
		}

		[Fact]
		public void ShouldAddToppingsToTotalCost()
		{
			var pizzaType = PizzaTypes.Capriciosa;

			var toppings = new List<ToppingType>()
			{
				ToppingType.Pineapple
			};

			var store = new BrisbanePizzeria();

			var orderedPizza = store.Order(pizzaType, toppings);

			var totalPrice = store.TotalPrice(new[] { orderedPizza });

			Assert.Equal(22, totalPrice, 2);
		}
	}
}
