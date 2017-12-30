using System;
using System.Collections.Generic;

namespace RealWorld
{
	/// <summary>
	/// A 'ConcreteStrategy' class
	/// </summary>
	public class QuickSort : SortStrategy
	{
		public override void Sort(List<string> list)
		{
			list.Sort(); // Default is quicksort
			Console.WriteLine("Quick-sorted list");
		}
	}
}
