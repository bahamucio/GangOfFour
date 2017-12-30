using System;
using System.Collections.Generic;

namespace RealWorld
{
	/// <summary>
	/// A 'ConcreteClass' class
	/// </summary>
	public class Categories : DataAccessObject
	{
		public override void Select()
		{
			dataSet = new List<string>
			{
				"Beverages",
				"Condiments",
				"Confections",
				"Dairy Products",
				"Grains/Cereals",
				"Meat/Poultry",
				"Produce",
				"Seafood"
			};
		}

		public override void Process()
		{
			Console.WriteLine("Categories ---- ");
			foreach(string row in dataSet)
			{
				Console.WriteLine(" " + row);
			}
		}
	}
}
