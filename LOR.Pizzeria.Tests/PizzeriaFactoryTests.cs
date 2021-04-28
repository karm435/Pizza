using System;
using Xunit;

namespace LOR.Pizzeria.Tests
{
	public class PizzeriaFactoryTests
	{
		[Fact]
		public void ShouldCreateBrisbanePizzeria()
		{
			var location = "Brisbane";

			var pizzeria = PizzeriaFactory.CreatePizzeria(location);

			Assert.Equal(pizzeria.Location, location);
		}
	}
}
