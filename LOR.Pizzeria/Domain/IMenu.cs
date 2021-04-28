using System.Collections;
using System.Collections.Generic;

namespace LOR.Pizzeria.Domain
{
    public interface IMenu
    {
        IEnumerable<IPizza> Pizzas { get; }
        
        IEnumerable<ITopping> Toppings { get;  }
        
        IDictionary<IPizza, decimal> PizzaPrices { get; }
        
    }
}