using System;

namespace RealWorld
{
	/// <summary>
	/// The 'RefinedAbstraction' class
	/// </summary>
	public class Customers : CustomerBase
	{
		public Customers(string group) : base(group)
		{
		}

		public override void ShowAll()
		{
			// Add separator lines
			Console.WriteLine();
			Console.WriteLine(" ------------------ ");
			base.ShowAll();
			Console.WriteLine(" ------------------ ");
		}
	}
}
