using System;
using System.Collections.Generic;

namespace Structural
{
	/// <summary>
	/// The 'Product' class
	/// </summary>
	public class Product
	{
		private List<string> _parts = new List<string>();

		public void Add(string part)
		{
			_parts.Add(part);
		}

		public void Show()
		{
			Console.WriteLine("\nProduct parts ------- ");
			foreach(string part in _parts)
			{	
				Console.WriteLine(part);
			}
		}
	}
}
