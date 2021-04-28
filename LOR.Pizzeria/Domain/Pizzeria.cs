using LOR.Pizzerias.Domain.Pizzas;
using LOR.Pizzeriass;
using System.Collections;

using System.Collections.Generic;

namespace LOR.Pizzerias.Domain
{
    public abstract class Pizzeria
    {
        public abstract string Location { get; }

        public abstract IMenu Menu { get; }

        public abstract void PrintReceipt(Pizza[] forOrderedPizzas);

        public void Order(string type)
		{
            var pizza = PizzaFactory.CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
        }
    }
}