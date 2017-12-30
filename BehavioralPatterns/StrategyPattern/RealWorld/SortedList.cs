using System;
using System.Collections.Generic;

namespace RealWorld
{
	/// <summary>
	/// The 'Context' class
	/// </summary>
	public class SortedList
	{
		private List<string> _list = new List<string>();
		private SortStrategy _sortStrategy;

		public void SetSortStrategy(SortStrategy sortStrategy)
		{
			_sortStrategy = sortStrategy;
		}

		public void Add(string name)
		{
			_list.Add(name);
		}

		public void Sort()
		{
			_sortStrategy.Sort(_list);

			foreach(string name in _list)
			{
				Console.WriteLine(" " + name);
			}
			Console.WriteLine();
		}
	}
}
