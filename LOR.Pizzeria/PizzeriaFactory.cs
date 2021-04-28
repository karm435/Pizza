using LOR.Pizzerias.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace LOR.Pizzerias
{
	public class PizzeriaFactory
	{
		public static Pizzeria CreatePizzeria(string location)
		{
			return location switch
			{
				"Brisbane" => new BrisbanePizzeria(),
				"Sydney" => new SydneyPizzeria(),
				_ => null
			};
		}
	}
}
