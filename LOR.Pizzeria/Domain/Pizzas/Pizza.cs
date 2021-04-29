using LOR.Pizzerias.Domain.Toppings;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LOR.Pizzerias.Domain.Pizzas
{
	public abstract class Pizza
	{
		public abstract List<string> Ingredients { get; }

		public List<ITopping> Toppings = new();
		
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
			if (Toppings.Count > 0)
			{
				Console.WriteLine("Adding selected Toppings");
				Console.Write("Adding ");
				foreach (var topping in Toppings)
				{
					Console.Write(topping.Type + " ");
				}
			}
			Console.WriteLine();
		}

		public override string ToString()
		{
			var pizza =  $"{Name} - {string.Join(",", Ingredients)}";
			if(Toppings.Count > 0)
			{
				return $"{pizza} with toppings {string.Join(",", Toppings.Select(t => t.Type.ToString()))}";
			}
			return pizza;
		}
	}
}