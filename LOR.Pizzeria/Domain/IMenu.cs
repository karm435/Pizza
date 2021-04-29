using LOR.Pizzerias.Domain.Pizzas;
using LOR.Pizzerias.Domain.Toppings;
using System.Collections;
using System.Collections.Generic;

namespace LOR.Pizzerias.Domain
{
    public interface IMenu
    {
        IEnumerable<Pizza> Pizzas { get; }
        
        IEnumerable<ToppingType> ToppingsAvailable { get;  }
        
        IDictionary<string, decimal> PizzaPrices { get; }
        IDictionary<ToppingType, decimal> ToppingsPrices { get; }
        
    }
}