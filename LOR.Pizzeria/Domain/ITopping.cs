namespace LOR.Pizzerias.Domain
{
    public interface ITopping
    {
        string Name { get; }

        decimal Quantity { get;  }

        decimal Price { get; }

        //Add total price as intergace method with default implementation
    }
}