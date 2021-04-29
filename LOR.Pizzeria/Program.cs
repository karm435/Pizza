using LOR.Pizzerias.Domain.Pizzas;
using System;
using System.Collections.Generic;

namespace LOR.Pizzerias
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LOR Pizzeria! Please select the store location: Brisbane OR Sydney");
            var store = Console.ReadLine();
            var pizzaStore = PizzeriaFactory.CreatePizzeria(store);
            if(pizzaStore == null)
			{
                Console.WriteLine($"Looks like we don't have a store at {store} location.");
                return;
			}

            Console.WriteLine("MENU");
			foreach (var availablePizza in pizzaStore.Menu.Pizzas)
			{
                Console.WriteLine(availablePizza.ToString() + $" {pizzaStore.Menu.PizzaPrices[availablePizza.Name]} AUD");
			}

            Console.WriteLine("What can I get you?");

            var pizzaType = Console.ReadLine();

			var pizza = pizzaStore.Order(pizzaType);
			if (pizza == null) return;

			pizzaStore.PrintReceipt(new[] { pizza });

            Console.WriteLine("\nYour pizza is ready!");
        }
    }
}
