using LOR.Pizzeria.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace LOR.Pizzeria
{
	public class PizzeriaFactory
	{
		public static IPizzeria CreatePizzeria(string location)
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
