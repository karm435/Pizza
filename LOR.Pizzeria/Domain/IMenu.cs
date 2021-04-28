using LOR.Pizzerias.Domain.Pizzas;
using System.Collections;
using System.Collections.Generic;

namespace LOR.Pizzerias.Domain
{
    public interface IMenu
    {
        IEnumerable<Pizza> Pizzas { get; }
        
        IEnumerable<ITopping> Toppings { get;  }
        
        IDictionary<string, decimal> PizzaPrices { get; }
        
    }
}