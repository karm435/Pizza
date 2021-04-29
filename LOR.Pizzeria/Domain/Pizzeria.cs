using LOR.Pizzerias.Domain.Pizzas;
using LOR.Pizzeriass;
using System;
using System.Collections;
using System.Linq;

using System.Collections.Generic;
using LOR.Pizzerias.Domain.Toppings;

namespace LOR.Pizzerias.Domain
{
    public abstract class Pizzeria
    {
        public abstract string Location { get; }

        public abstract IMenu Menu { get; }

        public virtual decimal TotalPrice(Pizza[] forOrderedPizzas)
		{
            var totalPrice = forOrderedPizzas.Sum(x => Menu.PizzaPrices[x.Name]);
			foreach (var pizza in forOrderedPizzas)
			{
                if(pizza.Toppings.Count > 0)
				{
					foreach (var topping in pizza.Toppings)
					{
                        totalPrice += Menu.ToppingsPrices[topping.Type];
					}
				}
			}
            return totalPrice;
        }

        public Pizza Order(PizzaTypes type, IEnumerable<ToppingType> withToppings = null)
		{
            var pizza = PizzaFactory.CreatePizza(type);
            if(pizza == null)
			{
                Console.WriteLine($"Selected {type} Pizza is not available at {Location}");
                return null;
			}
            if(withToppings != null && withToppings.Any())
			{
				foreach (var toppingType in withToppings)
				{
                    var topping = ToppingsFactory.CreateTopping(toppingType);
                    pizza.Toppings.Add(topping);
				}
			}
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
    }
}