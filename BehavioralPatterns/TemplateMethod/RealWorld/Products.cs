using System;
using System.Collections.Generic;

namespace RealWorld
{
	/// <summary>
	/// A 'ConcreteClass' class
	/// </summary>
	public class Products : DataAccessObject
	{
		public override void Select()
		{
			dataSet = new List<string>
			{
				"Chai",
				"Chang",
				"Aniseed syrup",
				"Chef Anton's Cajun Seasoning",
				"Cheg Anton's Gimbo mix",	
				"Grandma's Boysenberry Spread",
				"Uncle Bob's Organic Dried Pears",
				"Northwood Cranbery Sauce",
				"Mishi Kobe Niku"
			};
		}

		public override void Process()
		{
			Console.WriteLine("Products ---- ");
			foreach(string row in dataSet)
			{
				Console.WriteLine(" " + row);
			}
		}
	}
}
