using System.Collections;

using System.Collections.Generic;

namespace LOR.Pizzeria.Domain
{
    public interface IPizzeria
    {
        string Location { get; }

        IEnumerable<IMenu> Menu { get; }

        void PrintReceipt();
    }
}