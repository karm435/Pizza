namespace LOR.Pizzeria.Domain
{
    public interface ITopping
    {
        string Name { get; }

        decimal Quantity { get;  }
    }
}