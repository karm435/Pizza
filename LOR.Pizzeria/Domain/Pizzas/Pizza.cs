using System;
using System.Collections.Generic;
using System.Linq;

namespace LOR.Pizzerias.Domain.Pizzas
{
	public abstract class Pizza
	{
		public abstract List<string> Ingredients { get; }
		public abstract string Name { get; }

		public virtual void Bake()
		{
			Console.WriteLine("Baking pizza for 30 minutes at 200 degrees...");
		}
		public virtual void Box()
		{
			Console.WriteLine("Putting pizza into a nice box...");
		}
		public virtual void Cut()
		{
			Console.WriteLine("Cutting pizza into 8 slices...");
		}
		public void Prepare()
		{
			Console.WriteLine("Preparing " + Name + "...");
			Console.Write("Adding ");
			foreach (var i in Ingredients)
			{
				Console.Write(i + " ");
			}
			Console.WriteLine();
		}

		public override string ToString()
		{
			return $"${Name} - ${string.Join(",", Ingredients)}";
		}
	}
}