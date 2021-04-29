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
            if(pizzaStore == null)
			{
                WriteLine($"Looks like we don't have a store at {store} location.");
                return;
			}

            WriteLine("MENU", Console.ForegroundColor);
            WriteLine($"{pizzaStore.Location} has these Pizzas");
			foreach (var availablePizza in pizzaStore.Menu.Pizzas)
			{
                WriteLine(availablePizza.ToString() + $" {pizzaStore.Menu.PizzaPrices[availablePizza.Name]} AUD");
			}

            WriteLine("What can I get you?");

            var pizzaType = ReadLine();
            
            if (Enum.TryParse(typeof(PizzaTypes), pizzaType, out var selectedPizza)) {

                WriteLine("Toppings available", ConsoleColor.Green);
                foreach (var availableTopping in pizzaStore.Menu.ToppingsAvailable)
                {
                    WriteLine($"{availableTopping} for {pizzaStore.Menu.ToppingsPrices[availableTopping]}");
                }

                WriteLine("Would you like to add any toppings? Press y for Yes and n for No");

                var answer = ReadKey();
                var moreToppingsToAdd = "";
                var toppings = new List<ToppingType>();
                if(answer.Key.ToString().Equals("Y", StringComparison.InvariantCultureIgnoreCase))
				{
                    do
                    {
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

                        moreToppingsToAdd = ReadKey().Key.ToString();
                    } while (moreToppingsToAdd.Equals("Y", StringComparison.InvariantCultureIgnoreCase));
				}

                WriteLine();

                var pizza = pizzaStore.Order((PizzaTypes)selectedPizza, toppings);
                if (pizza == null) return;

                var totalPrice = pizzaStore.TotalPrice(new[] { pizza });
                WriteLine($"Total price is {totalPrice}");

                WriteLine("\nYour pizza is ready!");
            }
            else
			{
                WriteLine($"Selected pizza {pizzaType} is not available");
			}
			
        }
    }
}
