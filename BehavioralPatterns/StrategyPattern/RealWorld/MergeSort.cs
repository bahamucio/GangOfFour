using System;
using System.Collections.Generic;

namespace RealWorld
{
	/// <summary>
	/// A 'ConcreteStrategy' class
	/// </summary>
	public class MergeSort : SortStrategy
	{
		public override void Sort(List<string> list)
		{
			// list.MergeSort() not-implemented
			Console.WriteLine("Merge-sorted list");
		}
	}
}
