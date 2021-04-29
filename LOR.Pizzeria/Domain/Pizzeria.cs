using LOR.Pizzerias.Domain.Pizzas;
using LOR.Pizzeriass;
using System;
using System.Collections;
using System.Linq;

using System.Collections.Generic;

namespace LOR.Pizzerias.Domain
{
    public abstract class Pizzeria
    {
        public abstract string Location { get; }

        public abstract IMenu Menu { get; }

        public virtual void PrintReceipt(Pizza[] forOrderedPizzas)
		{
            var totalPrice = forOrderedPizzas.Sum(x => Menu.PizzaPrices[x.Name]);
            Console.WriteLine($"Total Price: {totalPrice}");
        }

        public Pizza Order(string type)
		{
            var pizza = PizzaFactory.CreatePizza(type);
            if(pizza == null)
			{
                Console.WriteLine($"Selected {type} Pizza is not available at {Location}");
                return null;
			}
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
    }
}