using System.Collections.Generic;

namespace LOR.Pizzeria.Domain
{
    public interface IPizza
    {
		List<string> Ingredients { get; set; }
		string Name { get; set; }

		void Bake();
		void Box();
		void Cut();
		void Prepare();
	}
}