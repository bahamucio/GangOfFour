using System;

namespace Structural
{
	/// <summary>
	/// The 'Leaf' class
	/// </summary>
	public class Leaf : Component
	{
		public Leaf(string name) : base(name)
		{
		}

		public override void Add(Component component)
		{
			Console.WriteLine("Cannot add to component.");
		}

		public override void Remove(Component component)
		{
			Console.WriteLine("Cannot remove from a leaf.");
		}

		public override void Display(int depth)
		{
			Console.WriteLine(new string('-', depth) + name);
		}
	}
}
