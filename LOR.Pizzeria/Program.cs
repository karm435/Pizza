using LOR.Pizzerias.Domain;
using LOR.Pizzerias.Domain.Pizzas;
using LOR.Pizzerias.Domain.Toppings;
using System;
using System.Collections.Generic;
using static System.Console;
namespace LOR.Pizzerias
{
    class Program
    {
        static void Main(string[] args)
		{
			WriteLine("Welcome to LOR Pizzeria! Please select the store location: Brisbane OR Sydney");
			var store = ReadLine();

			var pizzaStore = PizzeriaFactory.CreatePizzeria(store);
			if (pizzaStore == null)
			{
				WriteLine($"Looks like we don't have a store at {store} location.");
				return;
			}

			PrintMenuForStore(pizzaStore);

			var pizzasOrdered = new List<(PizzaTypes, List<ToppingType>)>();
			bool wouldLikeToOrderMore;
			do
			{
				WriteLine("What can I get you?");

				var pizzaType = ReadLine();

				if (Enum.TryParse(typeof(PizzaTypes), pizzaType, out var selectedPizza))
				{
					List<ToppingType> toppings = GetToppingsToAdd(pizzaStore);

					pizzasOrdered.Add(((PizzaTypes)selectedPizza, toppings));

					WriteLine();
				}
				else
				{
					WriteLine($"Selected pizza {pizzaType} is not available");
				}

				WriteLine("Would you like to order more pizzas? Press y for Yes and n for No");

				wouldLikeToOrderMore = ReadKey().Key.ToString().Equals("Y", StringComparison.InvariantCultureIgnoreCase);

				WriteLine();

			} while (wouldLikeToOrderMore);

			// Process the order
			var pizzas = new List<Pizza>();
			foreach (var orderedPizza in pizzasOrdered)
			{
				var pizza = pizzaStore.Order((PizzaTypes)orderedPizza.Item1, orderedPizza.Item2);
				pizzas.Add(pizza);
			}


			var totalPrice = pizzaStore.TotalPrice(pizzas.ToArray());

			WriteLine($"Total price is {totalPrice}");

			WriteLine("\nYour pizza is ready!");
		}

		private static void PrintMenuForStore(Pizzeria pizzaStore)
		{
			WriteLine("MENU", Console.ForegroundColor);

			WriteLine($"{pizzaStore.Location} has these Pizzas");
			foreach (var availablePizza in pizzaStore.Menu.Pizzas)
			{
				WriteLine(availablePizza.ToString() + $" {pizzaStore.Menu.PizzaPrices[availablePizza.Name]} AUD");
			}
		}

		private static List<ToppingType> GetToppingsToAdd(Pizzeria pizzaStore)
		{
			WriteLine("Toppings available");

			foreach (var availableTopping in pizzaStore.Menu.ToppingsAvailable)
			{
				WriteLine($"{availableTopping} for {pizzaStore.Menu.ToppingsPrices[availableTopping]}");
			}

			WriteLine("Would you like to add any toppings? Press y for Yes and n for No");


			var answer = ReadKey();
			var toppings = new List<ToppingType>();
			if (answer.Key.ToString().Equals("Y", StringComparison.InvariantCultureIgnoreCase))
			{
				bool moreToppingsToAdd;
				do
				{
					WriteLine();
					WriteLine("Which one do you want?");

					var toppingType = ReadLine();
					if (Enum.TryParse(typeof(ToppingType), toppingType, out var selectedTopping))
					{
						toppings.Add((ToppingType)selectedTopping);
					}
					else
					{
						WriteLine($"Looks like {toppingType} is not available");
					}

					WriteLine("Would you like to add more toppings? Press y for Yes and n for No");

					moreToppingsToAdd = ReadKey().Key.ToString().Equals("Y", StringComparison.InvariantCultureIgnoreCase);
					WriteLine();
				} while (moreToppingsToAdd);
			}

			return toppings;
		}
	}
}
