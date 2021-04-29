using LOR.Pizzerias.Domain.Toppings;

namespace LOR.Pizzerias.Domain
{
    public interface ITopping
    {
        ToppingType Type { get; }

        decimal Quantity { get; set; }

        decimal Price { get; }

        //Add total price as interface method with default implementation
    }
}